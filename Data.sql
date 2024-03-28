BEGIN
  EXECUTE IMMEDIATE 'DROP TABLE DANGKY';
  EXECUTE IMMEDIATE 'DROP TABLE PHANCONG';
  EXECUTE IMMEDIATE 'DROP TABLE KHMO';
  EXECUTE IMMEDIATE 'DROP TABLE HOCPHAN';
  EXECUTE IMMEDIATE 'DROP TABLE SINHVIEN';
  EXECUTE IMMEDIATE 'DROP TABLE NGANH';
  EXECUTE IMMEDIATE 'DROP TABLE DONVI CASCADE CONSTRAINTS';
  EXECUTE IMMEDIATE 'DROP TABLE NHANSU CASCADE CONSTRAINTS';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -942 THEN
      RAISE;
    END IF;
END;
/
CREATE TABLE NHANSU (
    MANV NUMBER PRIMARY KEY,
    HOTEN NVARCHAR2(100),
    PHAI NVARCHAR2(10),
    NGSINH DATE,
    PHUCAP NUMBER,
    DT NVARCHAR2(15),
    VAITRO NVARCHAR2(50),
    MADV NUMBER
);

CREATE TABLE SINHVIEN (
    MASV NUMBER PRIMARY KEY,
    HOTEN NVARCHAR2(100),
    PHAI NVARCHAR2(10),
    NGSINH DATE,
    DCHI NVARCHAR2(100),
    DT NVARCHAR2(15),
    MACT NUMBER,
    MANGANH NUMBER,
    SOTCTL NUMBER,
    DTBTL NUMBER
);

CREATE TABLE DONVI (
    MADV NUMBER PRIMARY KEY,
    TENDV NVARCHAR2(100),
    TRGDV NUMBER
);

CREATE TABLE HOCPHAN (
    MAHP NUMBER PRIMARY KEY,
    TENHP NVARCHAR2(100),
    SOTC NUMBER,
    STLT NUMBER,
    STTH NUMBER,
    SOSVTD NUMBER,
    MADV NUMBER
);

CREATE TABLE KHMO (
    MAHP NUMBER,
    HK NUMBER,
    NAM NUMBER,
    MACT NUMBER,
    PRIMARY KEY (MAHP, HK, NAM, MACT)
);

CREATE TABLE PHANCONG (
    MAGV NUMBER,
    MAHP NUMBER,
    HK NUMBER,
    NAM NUMBER,
    MACT NUMBER,
    PRIMARY KEY (MAGV, MAHP, HK, NAM, MACT)
);

CREATE TABLE DANGKY (
    MASV NUMBER,
    MAGV NUMBER,
    MAHP NUMBER,
    HK NUMBER,
    NAM NUMBER,
    MACT NUMBER,
    DIEMTH NUMBER,
    DIEMQT NUMBER,
    DIEMCK NUMBER,
    DIEMTK NUMBER,
    PRIMARY KEY (MASV, MAHP, HK, NAM, MACT)
);

CREATE TABLE NGANH(
    MANGANH NUMBER PRIMARY KEY,
    TENNGANH NVARCHAR2(50)
);

ALTER TABLE NHANSU 
ADD CONSTRAINT fk_madv_nhansu 
FOREIGN KEY (MADV) 
REFERENCES DONVI(MADV);

ALTER TABLE DONVI
ADD CONSTRAINT fk_trdv_nhansu
FOREIGN KEY (TRGDV)
REFERENCES NHANSU(MANV);

ALTER TABLE SINHVIEN
ADD CONSTRAINT fk_manganh_sinhvien 
FOREIGN KEY (MANGANH) 
REFERENCES NGANH(MANGANH);

ALTER TABLE HOCPHAN
ADD CONSTRAINT fk_madv_hocphan 
FOREIGN KEY (MADV) 
REFERENCES DONVI(MADV);

ALTER TABLE KHMO
ADD CONSTRAINT fk_mahp_khmo 
FOREIGN KEY (MAHP) 
REFERENCES HOCPHAN(MAHP);

ALTER TABLE PHANCONG
ADD CONSTRAINT fk_magv_phancong
FOREIGN KEY (MAGV) 
REFERENCES NHANSU(MANV);

ALTER TABLE PHANCONG
ADD CONSTRAINT fk_khmo_phancong 
FOREIGN KEY (MAHP,HK,NAM,MACT) 
REFERENCES KHMO(MAHP,HK,NAM,MACT);

ALTER TABLE DANGKY
ADD CONSTRAINT fk_masv_dangky 
FOREIGN KEY (MASV) 
REFERENCES SINHVIEN(MASV);

ALTER TABLE DANGKY
ADD CONSTRAINT fk_magv_dangky 
FOREIGN KEY (MAGV) 
REFERENCES NHANSU(MANV);

ALTER TABLE DANGKY
ADD CONSTRAINT fk_mahp_dangky 
FOREIGN KEY (MAHP,HK,NAM,MACT) 
REFERENCES KHMO(MAHP,HK,NAM,MACT);

----------------------------------------------------------
-- NHAP DU LIEU
INSERT INTO DONVI (MADV, TENDV) VALUES
(1, 'He Thong Thong Tin');
INSERT INTO DONVI (MADV, TENDV) VALUES
(2, 'Van Phong Khoa');
INSERT INTO DONVI (MADV, TENDV) VALUES
(3, 'Cong Nghe Phan Mem');
INSERT INTO DONVI (MADV, TENDV) VALUES
(4, 'Khoa Hoc May Tinh');
INSERT INTO DONVI (MADV, TENDV) VALUES
(5, 'An Toan Du Lieu va Bao Mat');
INSERT INTO DONVI (MADV, TENDV) VALUES
(6, 'Cong Nghe Thong Tin');
INSERT INTO DONVI (MADV, TENDV) VALUES
(7, 'Mang May Tinh va Vien Thong');
 
-- DATA ENTRY
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(001, 'Nguyen Hoai An', 'Male', TO_DATE('1970-01-01', 'YYYY-MM-DD'), 20000, '0835935835', 'Nhan vien co ban', 1);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(002, 'Tran Ha Huong', 'Female', TO_DATE('1970-01-02', 'YYYY-MM-DD'), 25000, '0953954852', 'Nhan vien co ban', 2);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(003, 'Nguyen Ngoc Anh', 'Female', TO_DATE('1990-01-03', 'YYYY-MM-DD'), 22000, '0744839557', 'Nhan vien co ban', 2);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(004, 'Truong Nam Son', 'Male', TO_DATE('1990-06-15', 'YYYY-MM-DD'), 23000, '083955437', 'Nhan vien co ban', 3);  
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(005, 'Ly Hoang Ha', 'Male', TO_DATE('1990-01-30', 'YYYY-MM-DD'), 30000, '0397346557', 'Nhan vien co ban', 1);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(006, 'Tran Bich Tuyet', 'Female', TO_DATE('1990-11-23', 'YYYY-MM-DD'), 27000, '0482957348', 'Nhan vien co ban', 5);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(007, 'Nguyen An Trung', 'Male', TO_DATE('1990-09-13', 'YYYY-MM-DD'), 22000, '0738362844', 'Nhan vien co ban', 3);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(008, 'Nguyen Trung Nam', 'Male', TO_DATE('1990-02-03', 'YYYY-MM-DD'), 25000, '09375847555', 'Nhan vien co ban', 6);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(009, 'Tran Trung Hieu', 'Male', TO_DATE('1990-05-05', 'YYYY-MM-DD'), 23000, '0839547493', 'Nhan vien co ban', 1);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(010, 'Pham Nam Thanh', 'Male', TO_DATE('1990-02-06', 'YYYY-MM-DD'), 21000, '0846382042', 'Nhan vien co ban', 1);

-- Giao vien 
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(011, 'Nguyen Thi Bich', 'Female', TO_DATE('1992-05-20', 'YYYY-MM-DD'), 20000, '0987654321', 'Giang vien', 1);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(012, 'Tran Van Cao', 'Male', TO_DATE('1988-08-12', 'YYYY-MM-DD'), 22000, '0976543210', 'Giang vien', 2);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(013, 'Pham Thi Dung', 'Female', TO_DATE('1991-04-25', 'YYYY-MM-DD'), 21000, '0965432109', 'Giang vien', 1);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(014, 'Hoang Van En', 'Male', TO_DATE('1993-09-30', 'YYYY-MM-DD'), 23000, '0954321098', 'Giang vien', 3);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(015, 'Vu Thi Phung', 'Female', TO_DATE('1990-06-15', 'YYYY-MM-DD'), 19000, '0943210987', 'Giang vien', 2);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(016, 'Le Van Giang', 'Male', TO_DATE('1995-01-10', 'YYYY-MM-DD'), 20000, '0932109876', 'Giang vien', 3);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(017, 'Nguyen Thi Huong', 'Female', TO_DATE('1993-07-05', 'YYYY-MM-DD'), 21000, '0921098765', 'Giang vien', 2);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(018, 'Tran Van In', 'Male', TO_DATE('1990-04-15', 'YYYY-MM-DD'), 22000, '0910987654', 'Giang vien', 1);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(019, 'Pham Thi Khanh Ly', 'Female', TO_DATE('1994-11-20', 'YYYY-MM-DD'), 23000, '0909876543', 'Giang vien', 3);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(020, 'Hoang Van Long', 'Male', TO_DATE('1989-08-25', 'YYYY-MM-DD'), 24000, '0898765432', 'Giang vien', 2);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(021, 'Vu Thi Mong', 'Female', TO_DATE('1992-03-30', 'YYYY-MM-DD'), 21000, '0887654321', 'Giang vien', 1);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(022, 'Dang Van Nam', 'Male', TO_DATE('1991-06-18', 'YYYY-MM-DD'), 22000, '0876543210', 'Giang vien', 2);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(023, 'Tran Thi Oanh', 'Female', TO_DATE('1993-09-22', 'YYYY-MM-DD'), 23000, '0865432109', 'Giang vien', 1);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(024, 'Le Van Phong', 'Male', TO_DATE('1990-02-14', 'YYYY-MM-DD'), 24000, '0854321098', 'Giang vien', 3);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(025, 'Nguyen Thi Quynh', 'Female', TO_DATE('1994-05-28', 'YYYY-MM-DD'), 21000, '0843210987', 'Giang vien', 2);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(026, 'Pham Van Trung', 'Male', TO_DATE('1992-08-16', 'YYYY-MM-DD'), 22000, '0832109876', 'Giang vien', 1);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(027, 'Hoang Thi Sinh', 'Female', TO_DATE('1991-01-05', 'YYYY-MM-DD'), 23000, '0821098765', 'Giang vien', 2);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(028, 'Vu Van Thanh', 'Male', TO_DATE('1993-04-10', 'YYYY-MM-DD'), 24000, '0810987654', 'Giang vien', 1);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(029, 'Tran Thi Uyen', 'Female', TO_DATE('1990-11-20', 'YYYY-MM-DD'), 21000, '0809876543', 'Giang vien', 3);
-- Giao vu
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(031, 'Tran Van Yen', 'Male', TO_DATE('1992-07-10', 'YYYY-MM-DD'), 22000, '0787654321', 'Giao vu', 1);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(032, 'Le Thi Giau', 'Female', TO_DATE('1993-05-15', 'YYYY-MM-DD'), 23000, '0776543210', 'Giao vu', 2);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(033, 'Nguyen Van An', 'Male', TO_DATE('1990-08-20', 'YYYY-MM-DD'), 24000, '0765432109', 'Giao vu', 3);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(034, 'Tran Thi Binh', 'Female', TO_DATE('1994-03-25', 'YYYY-MM-DD'), 21000, '0754321098', 'Giao vu', 1);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(035, 'Le Van Cuong', 'Male', TO_DATE('1989-10-30', 'YYYY-MM-DD'), 22000, '0743210987', 'Giao vu', 2);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(036, 'Nguyen Thi Duong', 'Female', TO_DATE('1991-09-05', 'YYYY-MM-DD'), 23000, '0732109876', 'Giao vu', 3);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(037, 'Tran Van Em', 'Male', TO_DATE('1993-11-12', 'YYYY-MM-DD'), 24000, '0721098765', 'Giao vu', 1);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(038, 'Le Thi Phuong', 'Female', TO_DATE('1990-02-18', 'YYYY-MM-DD'), 21000, '0710987654', 'Giao vu', 2);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(039, 'Nguyen Van Giao', 'Male', TO_DATE('1992-06-22', 'YYYY-MM-DD'), 22000, '0709876543', 'Giao vu', 3);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(040, 'Tran Thi Hang', 'Female', TO_DATE('1994-09-28', 'YYYY-MM-DD'), 23000, '0798765432', 'Giao vu', 1);

-- Truong don vi
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(041, 'Tran Van Xuyen', 'Male', TO_DATE('1978-05-20', 'YYYY-MM-DD'), 25000, '0961234567', 'Truong don vi', 1);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(043, 'Nguyen Van Anh', 'Male', TO_DATE('1975-12-10', 'YYYY-MM-DD'), 27000, '0963456789', 'Truong don vi', 3);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(044, 'Tran Thi Dep', 'Female', TO_DATE('1982-03-25', 'YYYY-MM-DD'), 28000, '0964567890', 'Truong don vi', 4);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(045, 'Le Van Chanh', 'Male', TO_DATE('1979-10-30', 'YYYY-MM-DD'), 29000, '0965678901', 'Truong don vi', 5);
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(046, 'Nguyen Thi Duyen', 'Female', TO_DATE('1981-09-05', 'YYYY-MM-DD'), 30000, '0966789012', 'Truong don vi', 6);
-- Truong khoa
INSERT INTO NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES 
(051, 'Nguyen Van Khoi', 'Male', TO_DATE('1976-06-15', 'YYYY-MM-DD'), 31000, '0967890123', 'Truong khoa', 2);


UPDATE DONVI SET TRGDV = 041 WHERE MADV = 1;
UPDATE DONVI SET TRGDV = 043 WHERE MADV = 3;
UPDATE DONVI SET TRGDV = 044 WHERE MADV = 4;
UPDATE DONVI SET TRGDV = 045 WHERE MADV = 5;
UPDATE DONVI SET TRGDV = 046 WHERE MADV = 6;
UPDATE DONVI SET TRGDV = 051 WHERE MADV = 2;

-- Nganh
INSERT INTO NGANH (MANGANH, TENNGANH) VALUES
(1, 'Cong Nghe Thong Tin');
INSERT INTO NGANH (MANGANH, TENNGANH) VALUES
(2, 'Ky Thuat Hoa Hoc');
INSERT INTO NGANH (MANGANH, TENNGANH) VALUES
(3, 'Kinh Te');
INSERT INTO NGANH (MANGANH, TENNGANH) VALUES
(4, 'Ngon Ngu Hoc');
INSERT INTO NGANH (MANGANH, TENNGANH) VALUES
(5, 'Toan Ung Dung');

-- Sinh vien-- Students
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(5, 'Le Thi Lan', 'Female', TO_DATE('2000-08-10', 'YYYY-MM-DD'), 'Address E', '0987654321', 2, 1, 20, 7.5);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(6, 'Tran Van Hung', 'Male', TO_DATE('2001-01-20', 'YYYY-MM-DD'), 'Address F', '0912345678', 3, 3, 28, 8.7);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(7, 'Nguyen Thi Thu', 'Female', TO_DATE('2000-04-05', 'YYYY-MM-DD'), 'Address G', '0987654321', 1, 2, 18, 7.2);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(8, 'Pham Van Tuan', 'Male', TO_DATE('2001-07-12', 'YYYY-MM-DD'), 'Address H', '0123456789', 4, 4, 30, 9.0);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(9, 'Hoang Thi Ha', 'Female', TO_DATE('2000-06-15', 'YYYY-MM-DD'), 'Address I', '0912345678', 1, 1, 24, 8.1);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(10, 'Tran Van Phuc', 'Male', TO_DATE('2001-02-20', 'YYYY-MM-DD'), 'Address K', '0987654321', 2, 2, 26, 8.5);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(11, 'Nguyen Thi Thanh', 'Female', TO_DATE('2000-09-05', 'YYYY-MM-DD'), 'Address L', '0912345678', 3, 3, 29, 8.8);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(12, 'Le Van Hung', 'Male', TO_DATE('2001-03-12', 'YYYY-MM-DD'), 'Address M', '0987654321', 1, 4, 21, 7.8);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(13, 'Pham Thi Ngoc', 'Female', TO_DATE('2000-05-20', 'YYYY-MM-DD'), 'Address N', '0123456789', 2, 1, 23, 7.7);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(14, 'Le Van Duong', 'Male', TO_DATE('2001-08-10', 'YYYY-MM-DD'), 'Address P', '0987654321', 3, 2, 27, 8.6);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(15, 'Nguyen Thi Ly', 'Female', TO_DATE('2000-11-20', 'YYYY-MM-DD'), 'Address Q', '0912345678', 4, 3, 25, 8.2);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(16, 'Tran Van Tai', 'Male', TO_DATE('2001-04-05', 'YYYY-MM-DD'), 'Address R', '0987654321', 1, 4, 22, 7.9);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(17, 'Le Thi Trang', 'Female', TO_DATE('2000-07-12', 'YYYY-MM-DD'), 'Address S', '0123456789', 2, 1, 19, 7.4);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(18, 'Nguyen Van Quan', 'Male', TO_DATE('2001-02-15', 'YYYY-MM-DD'), 'Address T', '0987654321', 3, 2, 24, 8.0);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(19, 'Tran Thi Huong', 'Female', TO_DATE('2000-09-20', 'YYYY-MM-DD'), 'Address U', '0912345678', 4, 3, 28, 8.8);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(20, 'Pham Van Nam', 'Male', TO_DATE('2001-06-12', 'YYYY-MM-DD'), 'Address V', '0987654321', 1, 4, 20, 7.6);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(21, 'Ly Thi Ngan', 'Female', TO_DATE('2000-12-05', 'YYYY-MM-DD'), 'Address X', '0123456789', 2, 1, 18, 7.3);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(22, 'Nguyen Van Dung', 'Male', TO_DATE('2001-05-20', 'YYYY-MM-DD'), 'Address Y', '0987654321', 3, 2, 23, 7.8);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(23, 'Tran Thi Tam', 'Female', TO_DATE('2000-10-12', 'YYYY-MM-DD'), 'Address Z', '0912345678', 4, 3, 26, 8.4);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(24, 'Pham Van An', 'Male', TO_DATE('2001-01-15', 'YYYY-MM-DD'), 'Address A1', '0987654321', 1, 4, 21, 7.7);
INSERT INTO SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) VALUES
(25, 'Ly Thi Thao', 'Female', TO_DATE('2000-08-20', 'YYYY-MM-DD'), 'Address B1', '0123456789', 2, 1, 24, 8.1);

--Hoc phan
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
(1, 'Lap trinh C++', 3, 2, 1, 50, 1);
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
(2, 'Hoa hoc huu co', 4, 2, 2, 60, 2);
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
(3, 'Quan tri kinh doanh', 3, 2, 1, 45, 3);
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
(4, 'Tiing Anh giao tiep', 3, 1, 2, 40, 4);
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
(5, 'Giai tich', 4, 3, 1, 55, 5);
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
(6, 'Ky thuat lap trinh', 4, 3, 1, 50, 1);
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
(7, 'Toan cao cap', 3, 2, 1, 45, 2);
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
(8, 'Marketing', 3, 2, 1, 40, 3);
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
(9, 'Kinh te hoc', 3, 1, 2, 35, 4);
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
(10, 'Dai so tuyen tinh', 4, 3, 1, 55, 5);
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
(11, 'Quan ly du an', 3, 2, 1, 45, 1);
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
(12, 'Lich su triet hoc', 3, 1, 2, 40, 2);
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
(13, 'Thong ke kinh te', 4, 3, 1, 60, 3);
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
(14, 'Quan tri mang', 3, 2, 1, 50, 4);
INSERT INTO HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTD, MADV) VALUES
(15, 'Hoa hoc vo co', 4, 3, 1, 55, 5);

-- KHMO 
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(1, 1, 2023, 1);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(2, 1, 2023, 2);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(3, 2, 2023, 3);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(4, 2, 2023, 4);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(5, 3, 2023, 5);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(6, 1, 2023, 1);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(7, 1, 2023, 2);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(8, 2, 2023, 3);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(9, 2, 2023, 4);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(10, 3, 2023, 5);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(11, 1, 2023, 1);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(12, 1, 2023, 2);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(13, 2, 2023, 3);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(14, 2, 2023, 4);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(15, 3, 2023, 5);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(14, 1, 2023, 1);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(13, 1, 2023, 2);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(12, 2, 2023, 3);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(11, 2, 2023, 4);
INSERT INTO KHMO (MAHP, HK, NAM, MACT) VALUES
(12, 3, 2023, 5);

-- Phan cong 
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(001, 1, 1, 2023, 1);
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(001, 2, 1, 2023, 2);
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(003, 3, 2, 2023, 3);
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(003, 4, 2, 2023, 4);
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(005, 5, 3, 2023, 5);
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(005, 6, 1, 2023, 1);
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(007, 7, 1, 2023, 2);
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(010, 8, 2, 2023, 3);
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(009, 9, 2, 2023, 4);
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(010, 10, 3, 2023, 5);
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(011, 11, 1, 2023, 1);
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(012, 12, 1, 2023, 2);
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(012, 13, 2, 2023, 3);
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(012, 14, 2, 2023, 4);
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(015, 5, 3, 2023, 5);
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(016, 6, 1, 2023, 1);
INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES
(017, 7, 1, 2023, 2);

-- Dang ky
INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
(6, 1, 1, 1, 2023, 1, 8.5, 7.5, 8.0, 8.0);
INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
(7, 2, 2, 1, 2023, 2, 7.0, 6.5, 7.5, 7.0);
INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
(13, 3, 3, 2, 2023, 3, 9.0, 8.5, 8.5, 8.7);
INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
(14, 4, 4, 2, 2023, 4, 7.5, 8.0, 7.0, 7.5);
INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
(15, 5, 5, 3, 2023, 5, 8.0, 8.5, 9.0, 8.5);
INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
(16, 6, 1, 1, 2023, 1, 8.0, 8.0, 8.5, 8.2);
INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
(17, 7, 2, 1, 2023, 2, 6.5, 7.0, 6.0, 6.5);
INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
(18, 8, 3, 2, 2023, 3, 9.5, 9.0, 9.0, 9.2);
INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
(19, 9, 4, 2, 2023, 4, 7.0, 7.5, 8.0, 7.5);
INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK) VALUES
(11, 10, 5, 3, 2023, 5, 8.5, 8.0, 8.5, 8.3);

