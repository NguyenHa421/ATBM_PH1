ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

BEGIN
  EXECUTE IMMEDIATE 'DROP TABLE TB_DANGKY';
  EXECUTE IMMEDIATE 'DROP TABLE TB_PHANCONG';
  EXECUTE IMMEDIATE 'DROP TABLE TB_KHMO';
  EXECUTE IMMEDIATE 'DROP TABLE TB_HOCPHAN';
  EXECUTE IMMEDIATE 'DROP TABLE TB_SINHVIEN';
  EXECUTE IMMEDIATE 'DROP TABLE TB_NGANH';
  EXECUTE IMMEDIATE 'DROP TABLE TB_DONVI CASCADE CONSTRAINTS';
  EXECUTE IMMEDIATE 'DROP TABLE TB_NHANSU CASCADE CONSTRAINTS';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -942 THEN
      RAISE;
    END IF;
END;
/
CREATE TABLE TB_NHANSU (
    MANV NVARCHAR2(5) PRIMARY KEY,
    HOTEN NVARCHAR2(100),
    PHAI NVARCHAR2(10),
    NGSINH DATE,
    PHUCAP NUMBER,
    DT NVARCHAR2(15),
    VAITRO NVARCHAR2(50),
    MADV NVARCHAR2(5)
);

CREATE TABLE TB_SINHVIEN (
    MASV NVARCHAR2(5) PRIMARY KEY,
    HOTEN NVARCHAR2(100),
    PHAI NVARCHAR2(10),
    NGSINH DATE,
    DCHI NVARCHAR2(100),
    DT NVARCHAR2(15),
    MACT NVARCHAR2(5),
    MANGANH NVARCHAR2(5),
    SOTCTL NUMBER,
    DTBTL NUMBER
);

CREATE TABLE TB_DONVI (
    MADV NVARCHAR2(5) PRIMARY KEY,
    TENDV NVARCHAR2(100),
    TRGDV NVARCHAR2(5)
);

CREATE TABLE TB_HOCPHAN (
    MAHP NVARCHAR2(5) PRIMARY KEY,
    TENHP NVARCHAR2(100),
    SOTC NUMBER,
    STLT NUMBER,
    STTH NUMBER,
    SOSVTD NUMBER,
    MADV NVARCHAR2(5)
);

CREATE TABLE TB_KHMO (
    MAHP NVARCHAR2(5),
    HK NUMBER,
    NAM NUMBER,
    MACT NVARCHAR2(5),
    PRIMARY KEY (MAHP, HK, NAM, MACT)
);

CREATE TABLE TB_PHANCONG (
    MAGV NVARCHAR2(5),
    MAHP NVARCHAR2(5),
    HK NUMBER,
    NAM NUMBER,
    MACT NVARCHAR2(5),
    PRIMARY KEY (MAGV, MAHP, HK, NAM, MACT)
);

CREATE TABLE TB_DANGKY (
    MASV NVARCHAR2(5),
    MAGV NVARCHAR2(5),
    MAHP NVARCHAR2(5),
    HK NUMBER,
    NAM NUMBER,
    MACT NVARCHAR2(5),
    DIEMTH NUMBER,
    DIEMQT NUMBER,
    DIEMCK NUMBER,
    DIEMTK NUMBER,
    PRIMARY KEY (MASV, MAHP, HK, NAM, MACT)
);

CREATE TABLE TB_NGANH(
    MANGANH NVARCHAR2(5) PRIMARY KEY,
    TENNGANH NVARCHAR2(50)
);

ALTER TABLE TB_NHANSU 
ADD CONSTRAINT fk_madv_TB_NHANSU 
FOREIGN KEY (MADV) 
REFERENCES TB_DONVI(MADV);

ALTER TABLE TB_DONVI
ADD CONSTRAINT fk_trdv_NHANSU
FOREIGN KEY (TRGDV)
REFERENCES TB_NHANSU(MANV);

ALTER TABLE TB_SINHVIEN
ADD CONSTRAINT fk_maNGANH_SINHVIEN 
FOREIGN KEY (MANGANH) 
REFERENCES TB_NGANH(MANGANH);

ALTER TABLE TB_HOCPHAN
ADD CONSTRAINT fk_madv_HOCPHAN 
FOREIGN KEY (MADV) 
REFERENCES TB_DONVI(MADV);

ALTER TABLE TB_KHMO
ADD CONSTRAINT fk_mahp_KHMO 
FOREIGN KEY (MAHP) 
REFERENCES TB_HOCPHAN(MAHP);

ALTER TABLE TB_PHANCONG
ADD CONSTRAINT fk_magv_PHANCONG
FOREIGN KEY (MAGV) 
REFERENCES TB_NHANSU(MANV);

ALTER TABLE TB_PHANCONG
ADD CONSTRAINT fk_KHMO_PHANCONG 
FOREIGN KEY (MAHP,HK,NAM,MACT) 
REFERENCES TB_KHMO(MAHP,HK,NAM,MACT);

ALTER TABLE TB_DANGKY
ADD CONSTRAINT fk_masv_DANGKY 
FOREIGN KEY (MASV) 
REFERENCES TB_SINHVIEN(MASV);

ALTER TABLE TB_DANGKY
ADD CONSTRAINT fk_magv_DANGKY 
FOREIGN KEY (MAGV) 
REFERENCES TB_NHANSU(MANV);

ALTER TABLE TB_DANGKY
ADD CONSTRAINT fk_mahp_DANGKY 
FOREIGN KEY (MAHP,HK,NAM,MACT) 
REFERENCES TB_KHMO(MAHP,HK,NAM,MACT);

----------------------------------------------------------
-- NHAP DU LIEU
INSERT INTO TB_DONVI (MADV, TENDV) VALUES
('DV01', 'He Thong Thong Tin');
INSERT INTO TB_DONVI (MADV, TENDV) VALUES
('DV02', 'Van Phong Khoa');
INSERT INTO TB_DONVI (MADV, TENDV) VALUES
('DV03', 'Cong Nghe Phan Mem');
INSERT INTO TB_DONVI (MADV, TENDV) VALUES
('DV04', 'Khoa Hoc May Tinh');
INSERT INTO TB_DONVI (MADV, TENDV) VALUES
('DV05', 'Thi Giac May Tinh');
INSERT INTO TB_DONVI (MADV, TENDV) VALUES
('DV06', 'Cong Nghe Thong Tin');
INSERT INTO TB_DONVI (MADV, TENDV) VALUES
('DV07', 'Mang May Tinh va Vien Thong');
 
-- DATA ENTRY
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS01', 'Nguyen Hoai An', 'Male', TO_DATE('1970-01-01', 'YYYY-MM-DD'), 20000, '0835935835', 'Nhan vien co ban', 'DV01');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS02', 'Tran Ha Huong', 'Female', TO_DATE('1970-01-02', 'YYYY-MM-DD'), 25000, '0953954852', 'Nhan vien co ban', 'DV02');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS03', 'Nguyen Ngoc Anh', 'Female', TO_DATE('1990-01-03', 'YYYY-MM-DD'), 22000, '0744839557', 'Nhan vien co ban', 'DV02');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS04', 'Truong Nam Son', 'Male', TO_DATE('1990-06-15', 'YYYY-MM-DD'), 23000, '083955437', 'Nhan vien co ban', 'DV03');  
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS05', 'Ly Hoang Ha', 'Male', TO_DATE('1990-01-30', 'YYYY-MM-DD'), 30000, '0397346557', 'Nhan vien co ban', 'DV01');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS06', 'Tran Bich Tuyet', 'Female', TO_DATE('1990-11-23', 'YYYY-MM-DD'), 27000, '0482957348', 'Nhan vien co ban', 'DV05');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS07', 'Nguyen An Trung', 'Male', TO_DATE('1990-09-13', 'YYYY-MM-DD'), 22000, '0738362844', 'Nhan vien co ban', 'DV03');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS08', 'Nguyen Trung Nam', 'Male', TO_DATE('1990-02-03', 'YYYY-MM-DD'), 25000, '09375847555', 'Nhan vien co ban', 'DV06');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS09', 'Tran Trung Hieu', 'Male', TO_DATE('1990-05-05', 'YYYY-MM-DD'), 23000, '0839547493', 'Nhan vien co ban', 'DV01');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS10', 'Pham Nam Thanh', 'Male', TO_DATE('1990-02-06', 'YYYY-MM-DD'), 21000, '0846382042', 'Nhan vien co ban', 'DV01');

-- Giao vien 
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS11', 'Nguyen Thi Bich', 'Female', TO_DATE('1992-05-20', 'YYYY-MM-DD'), 20000, '0987654321', 'Giang vien', 'DV01');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS12', 'Tran Van Cao', 'Male', TO_DATE('1988-08-12', 'YYYY-MM-DD'), 22000, '0976543210', 'Giang vien', 'DV02');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS13', 'Pham Thi Dung', 'Female', TO_DATE('1991-04-25', 'YYYY-MM-DD'), 21000, '0965432109', 'Giang vien', 'DV01');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS14', 'Hoang Van En', 'Male', TO_DATE('1993-09-30', 'YYYY-MM-DD'), 23000, '0954321098', 'Giang vien', 'DV03');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS15', 'Vu Thi Phung', 'Female', TO_DATE('1990-06-15', 'YYYY-MM-DD'), 19000, '0943210987', 'Giang vien', 'DV02');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS16', 'Le Van Giang', 'Male', TO_DATE('1995-01-10', 'YYYY-MM-DD'), 20000, '0932109876', 'Giang vien', 'DV03');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS17', 'Nguyen Thi Huong', 'Female', TO_DATE('1993-07-05', 'YYYY-MM-DD'), 21000, '0921098765', 'Giang vien', 'DV02');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS18', 'Tran Van In', 'Male', TO_DATE('1990-04-15', 'YYYY-MM-DD'), 22000, '0910987654', 'Giang vien', 'DV01');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS19', 'Pham Thi Khanh Ly', 'Female', TO_DATE('1994-11-20', 'YYYY-MM-DD'), 23000, '0909876543', 'Giang vien', 'DV03');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS20', 'Hoang Van Long', 'Male', TO_DATE('1989-08-25', 'YYYY-MM-DD'), 24000, '0898765432', 'Giang vien', 'DV02');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS21', 'Vu Thi Mong', 'Female', TO_DATE('1992-03-30', 'YYYY-MM-DD'), 21000, '0887654321', 'Giang vien', 'DV01');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS22', 'Dang Van Nam', 'Male', TO_DATE('1991-06-18', 'YYYY-MM-DD'), 22000, '0876543210', 'Giang vien', 'DV02');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS23', 'Tran Thi Oanh', 'Female', TO_DATE('1993-09-22', 'YYYY-MM-DD'), 23000, '0865432109', 'Giang vien', 'DV01');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS24', 'Le Van Phong', 'Male', TO_DATE('1990-02-14', 'YYYY-MM-DD'), 24000, '0854321098', 'Giang vien', 'DV03');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS25', 'Nguyen Thi Quynh', 'Female', TO_DATE('1994-05-28', 'YYYY-MM-DD'), 21000, '0843210987', 'Giang vien', 'DV02');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS26', 'Pham Van Trung', 'Male', TO_DATE('1992-08-16', 'YYYY-MM-DD'), 22000, '0832109876', 'Giang vien', 'DV01');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS27', 'Hoang Thi Sinh', 'Female', TO_DATE('1991-01-05', 'YYYY-MM-DD'), 23000, '0821098765', 'Giang vien', 'DV02');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS28', 'Vu Van Thanh', 'Male', TO_DATE('1993-04-10', 'YYYY-MM-DD'), 24000, '0810987654', 'Giang vien', 'DV01');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS29', 'Tran Thi Uyen', 'Female', TO_DATE('1990-11-20', 'YYYY-MM-DD'), 21000, '0809876543', 'Giang vien', 'DV03');
-- Giao vu
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS31', 'Tran Van Yen', 'Male', TO_DATE('1992-07-10', 'YYYY-MM-DD'), 22000, '0787654321', 'Giao vu', 'DV01');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS32', 'Le Thi Giau', 'Female', TO_DATE('1993-05-15', 'YYYY-MM-DD'), 23000, '0776543210', 'Giao vu', 'DV02');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS33', 'Nguyen Van An', 'Male', TO_DATE('1990-08-20', 'YYYY-MM-DD'), 24000, '0765432109', 'Giao vu', 'DV03');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS34', 'Tran Thi Binh', 'Female', TO_DATE('1994-03-25', 'YYYY-MM-DD'), 21000, '0754321098', 'Giao vu', 'DV01');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS35', 'Le Van Cuong', 'Male', TO_DATE('1989-10-30', 'YYYY-MM-DD'), 22000, '0743210987', 'Giao vu', 'DV02');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS36', 'Nguyen Thi Duong', 'Female', TO_DATE('1991-09-05', 'YYYY-MM-DD'), 23000, '0732109876', 'Giao vu', 'DV03');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS37', 'Tran Van Em', 'Male', TO_DATE('1993-11-12', 'YYYY-MM-DD'), 24000, '0721098765', 'Giao vu', 'DV01');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS38', 'Le Thi Phuong', 'Female', TO_DATE('1990-02-18', 'YYYY-MM-DD'), 21000, '0710987654', 'Giao vu', 'DV02');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS39', 'Nguyen Van Giao', 'Male', TO_DATE('1992-06-22', 'YYYY-MM-DD'), 22000, '0709876543', 'Giao vu', 'DV03');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS40', 'Tran Thi Hang', 'Female', TO_DATE('1994-09-28', 'YYYY-MM-DD'), 23000, '0798765432', 'Giao vu', 'DV01');

-- Truong don vi
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS41', 'Tran Van Xuyen', 'Male', TO_DATE('1978-05-20', 'YYYY-MM-DD'), 25000, '0961234567', 'Truong don vi', 'DV01');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS43', 'Nguyen Van Anh', 'Male', TO_DATE('1975-12-10', 'YYYY-MM-DD'), 27000, '0963456789', 'Truong don vi', 'DV03');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS44', 'Tran Thi Dep', 'Female', TO_DATE('1982-03-25', 'YYYY-MM-DD'), 28000, '0964567890', 'Truong don vi', 'DV04');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS45', 'Le Van Chanh', 'Male', TO_DATE('1979-10-30', 'YYYY-MM-DD'), 29000, '0965678901', 'Truong don vi', 'DV05');
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS46', 'Nguyen Thi Duyen', 'Female', TO_DATE('1981-09-05', 'YYYY-MM-DD'), 30000, '0966789012', 'Truong don vi', 'DV06');
-- Truong khoa
INSERT INTO TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
('NS51', 'Nguyen Van Khoi', 'Male', TO_DATE('1976-06-15', 'YYYY-MM-DD'), 31000, '0967890123', 'Truong khoa', 'DV02');


UPDATE TB_DONVI SET TRGDV = 'NS41' WHERE MADV = 'DV01';
UPDATE TB_DONVI SET TRGDV = 'NS43' WHERE MADV = 'DV03';
UPDATE TB_DONVI SET TRGDV = 'NS44' WHERE MADV = 'DV04';
UPDATE TB_DONVI SET TRGDV = 'NS45' WHERE MADV = 'DV05';
UPDATE TB_DONVI SET TRGDV = 'NS46' WHERE MADV = 'DV06';
UPDATE TB_DONVI SET TRGDV = 'NS51' WHERE MADV = 'DV02';

-- TB_NGANH
INSERT INTO TB_NGANH (MANGANH, TENNGANH) VALUES
('N01', 'Cong Nghe Thong Tin');
INSERT INTO TB_NGANH (MANGANH, TENNGANH) VALUES
('N02', 'Ky Thuat Hoa Hoc');
INSERT INTO TB_NGANH (MANGANH, TENNGANH) VALUES
('N03', 'Kinh Te');
INSERT INTO TB_NGANH (MANGANH, TENNGANH) VALUES
('N04', 'Ngon Ngu Hoc');
INSERT INTO TB_NGANH (MANGANH, TENNGANH) VALUES
('N05', 'Toan Ung Dung');

-- Sinh vien-- Students
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV05', 'Le Thi Lan', 'Female', TO_DATE('2000-08-10', 'YYYY-MM-DD'), 'Address E', '0987654321', 'CT02', 'N01', 20, 7.5);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV06', 'Tran Van Hung', 'Male', TO_DATE('2001-01-20', 'YYYY-MM-DD'), 'Address F', '0912345678', 'CT03', 'N03', 28, 8.7);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV07', 'Nguyen Thi Thu', 'Female', TO_DATE('2000-04-05', 'YYYY-MM-DD'), 'Address G', '0987654321', 'CT01', 'N02', 18, 7.2);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV08', 'Pham Van Tuan', 'Male', TO_DATE('2001-07-12', 'YYYY-MM-DD'), 'Address H', '0123456789', 'CT04', 'N04', 30, 9.0);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV09', 'Hoang Thi Ha', 'Female', TO_DATE('2000-06-15', 'YYYY-MM-DD'), 'Address I', '0912345678', 'CT01', 'N01', 24, 8.1);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV10', 'Tran Van Phuc', 'Male', TO_DATE('2001-02-20', 'YYYY-MM-DD'), 'Address K', '0987654321', 'CT02', 'N02', 26, 8.5);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV11', 'Nguyen Thi Thanh', 'Female', TO_DATE('2000-09-05', 'YYYY-MM-DD'), 'Address L', '0912345678', 'CT03', 'N03', 29, 8.8);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV12', 'Le Van Hung', 'Male', TO_DATE('2001-03-12', 'YYYY-MM-DD'), 'Address M', '0987654321', 'CT01', 'N04', 21, 7.8);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV13', 'Pham Thi Ngoc', 'Female', TO_DATE('2000-05-20', 'YYYY-MM-DD'), 'Address N', '0123456789', 'CT02', 'N01', 23, 7.7);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV14', 'Le Van Duong', 'Male', TO_DATE('2001-08-10', 'YYYY-MM-DD'), 'Address P', '0987654321', 'CT03', 'N02', 27, 8.6);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV15', 'Nguyen Thi Ly', 'Female', TO_DATE('2000-11-20', 'YYYY-MM-DD'), 'Address Q', '0912345678', 'CT04', 'N03', 25, 8.2);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV16', 'Tran Van Tai', 'Male', TO_DATE('2001-04-05', 'YYYY-MM-DD'), 'Address R', '0987654321', 'CT01', 'N04', 22, 7.9);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV17', 'Le Thi Trang', 'Female', TO_DATE('2000-07-12', 'YYYY-MM-DD'), 'Address S', '0123456789', 'CT02', 'N01', 19, 7.4);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV18', 'Nguyen Van Quan', 'Male', TO_DATE('2001-02-15', 'YYYY-MM-DD'), 'Address T', '0987654321', 'CT03', 'N02', 24, 8.0);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV19', 'Tran Thi Huong', 'Female', TO_DATE('2000-09-20', 'YYYY-MM-DD'), 'Address U', '0912345678', 'CT04', 'N03', 28, 8.8);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV20', 'Pham Van Nam', 'Male', TO_DATE('2001-06-12', 'YYYY-MM-DD'), 'Address V', '0987654321', 'CT01', 'N04', 20, 7.6);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV21', 'Ly Thi Ngan', 'Female', TO_DATE('2000-12-05', 'YYYY-MM-DD'), 'Address X', '0123456789', 'CT02', 'N01', 18, 7.3);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV22', 'Nguyen Van Dung', 'Male', TO_DATE('2001-05-20', 'YYYY-MM-DD'), 'Address Y', '0987654321', 'CT03', 'N02', 23, 7.8);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV23', 'Tran Thi Tam', 'Female', TO_DATE('2000-10-12', 'YYYY-MM-DD'), 'Address Z', '0912345678', 'CT04', 'N03', 26, 8.4);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV24', 'Pham Van An', 'Male', TO_DATE('2001-01-15', 'YYYY-MM-DD'), 'Address A1', '0987654321', 'CT01', 'N04', 21, 7.7);
INSERT INTO TB_SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
('SV25', 'Ly Thi Thao', 'Female', TO_DATE('2000-08-20', 'YYYY-MM-DD'), 'Address B1', '0123456789', 'CT02', 'N01', 24, 8.1);

--Hoc phan
INSERT INTO TB_HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
('HP01', 'Lap trinh C++', 3, 2, 1, 50, 'DV01');
INSERT INTO TB_HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
('HP02', 'Hoa hoc huu co', 4, 2, 2, 60, 'DV02');
INSERT INTO TB_HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
('HP03', 'Quan tri kinh doanh', 3, 2, 1, 45, 'DV03');
INSERT INTO TB_HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
('HP04', 'Tieng Anh giao tiep', 3, 1, 2, 40, 'DV04');
INSERT INTO TB_HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
('HP05', 'Giai tich', 4, 3, 1, 55, 'DV05');
INSERT INTO TB_HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
('HP06', 'Ky thuat lap trinh', 4, 3, 1, 50, 'DV01');
INSERT INTO TB_HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
('HP07', 'Toan cao cap', 3, 2, 1, 45, 'DV02');
INSERT INTO TB_HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
('HP08', 'Marketing', 3, 2, 1, 40, 'DV03');
INSERT INTO TB_HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
('HP09', 'Kinh te hoc', 3, 1, 2, 35, 'DV04');
INSERT INTO TB_HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
('HP10', 'Dai so tuyen tinh', 4, 3, 1, 55, 'DV05');
INSERT INTO TB_HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
('HP11', 'Quan ly du an', 3, 2, 1, 45, 'DV01');
INSERT INTO TB_HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
('HP12', 'Lich su triet hoc', 3, 1, 2, 40, 'DV02');
INSERT INTO TB_HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
('HP13', 'Thong ke kinh te', 4, 3, 1, 60, 'DV03');
INSERT INTO TB_HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
('HP14', 'Quan tri mang', 3, 2, 1, 50, 'DV04');
INSERT INTO TB_HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
('HP15', 'Hoa hoc vo co', 4, 3, 1, 55, 'DV05');

-- TB_KHMO 
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP01', 1, 2023, 'CT01');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP02', 1, 2023, 'CT02');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP03', 2, 2023, 'CT03');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP04', 2, 2023, 'CT04');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP05', 3, 2023, 'CT05');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP06', 1, 2023, 'CT01');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP07', 1, 2023, 'CT02');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP08', 2, 2023, 'CT03');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP09', 2, 2023, 'CT04');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP10', 3, 2023, 'CT05');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP11', 1, 2023, 'CT01');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP12', 1, 2023, 'CT02');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP13', 2, 2023, 'CT03');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP14', 2, 2023, 'CT04');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP15', 3, 2023, 'CT05');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP14', 1, 2023, 'CT01');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP13', 1, 2023, 'CT02');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP12', 2, 2023, 'CT03');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP11', 2, 2023, 'CT04');
INSERT INTO TB_KHMO (MAHP, HK, NAM, MACT) VALUES
('HP12', 3, 2023, 'CT05');

-- Phan cong 
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS01', 'HP01', 1, 2023, 'CT01');
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS01', 2, 1, 2023, 'CT02');
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS03', 3, 2, 2023, 'CT03');
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS03', 4, 2, 2023, 'CT04');
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS05', 5, 3, 2023, 'CT05');
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS05', 6, 1, 2023, 'CT01');
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS07', 7, 1, 2023, 'CT02');
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS10', 8, 2, 2023, 'CT03');
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS09', 9, 2, 2023, 'CT04');
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS10', 10, 3, 2023, 'CT05');
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS11', 11, 1, 2023, 'CT01');
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS12', 12, 1, 2023, 'CT02');
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS12', 13, 2, 2023, 'CT03');
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS12', 14, 2, 2023, 'CT04');
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS15', 5, 3, 2023, 'CT05');
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS16', 6, 1, 2023, 'CT01');
INSERT INTO TB_PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
('NS17', 7, 1, 2023, 'CT02');

-- Dang ky
INSERT INTO TB_DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
('SV06', 'NS01', 'HP01', 1, 2023, 'CT01', 8.5, 7.5, 8.0, 8.0);
INSERT INTO TB_DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
('SV07', 'NS02', 'HP02', 1, 2023, 'CT02', 7.0, 6.5, 7.5, 7.0);
INSERT INTO TB_DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
('SV13', 'NS03', 'HP03', 2, 2023, 'CT03', 9.0, 8.5, 8.5, 8.7);
INSERT INTO TB_DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
('SV14', 'NS04', 'HP04', 2, 2023, 'CT04', 7.5, 8.0, 7.0, 7.5);
INSERT INTO TB_DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
('SV15', 'NS05', 'HP05', 3, 2023, 'CT05', 8.0, 8.5, 9.0, 8.5);
INSERT INTO TB_DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
('SV16', 'NS06', 'HP01', 1, 2023, 'CT01', 8.0, 8.0, 8.5, 8.2);
INSERT INTO TB_DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
('SV17', 'NS07', 'HP02', 1, 2023, 'CT02', 6.5, 7.0, 6.0, 6.5);
INSERT INTO TB_DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
('SV18', 'NS08', 'HP03', 2, 2023, 'CT03', 9.5, 9.0, 9.0, 9.2);
INSERT INTO TB_DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
('SV19', 'NS09', 'HP04', 2, 2023, 'CT04', 7.0, 7.5, 8.0, 7.5);
INSERT INTO TB_DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
('SV11', 'NS10', 'HP05', 3, 2023, 'CT05', 8.5, 8.0, 8.5, 8.3);


