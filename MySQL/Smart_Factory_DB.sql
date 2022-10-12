DROP DATABASE IF EXISTS Smart_Factory_DB;
CREATE DATABASE Smart_Factory_DB;
USE Smart_Factory_DB;
/* =============== DATEBASE STRUCTURE ============== *
 * | DHT11_TEMP_WET_TBL    | RFID_TBL              | *
 * ------------------------------------------------- *
 * | id(N)(U)(PK)(AI)(INT) | id(N)(U)(PK)(AI)(INT) | *
 * | temp(INT)             | rfid(VARCHAR)         | *
 * | wet(INT)              | num(VARCHAR)          | *
 * | dht11_temp(INT)       | name(VARCHAR)         | *
 * | dht11_wet(INT)        | depart(VARCHAR)       | *
 * | date(DATETIME)        | pos(VARCHAR)          | *
 * |                       | phone(VARCHAR)        | *
 * |                       | enter_date(DATETIME)  | *
 * ================================================= */
/* ========================== RFID_TBL ========================= *
 * | 0                 | 1                 | 2                 | *
 * | 7C 78 4C 79       | 47 1D 95 5F       | 11 DE 66 A3       | *
 * | 7777777           | 88888888          | 890310            | *
 * | 칠칠이            | 팔팔이            | 김진혁            | *
 * | 칠성              | 팔도              | 서울기술교육센터  | *
 * | 계약직            | 정규직            | 교육생            | *
 * | 010-7777-7777     | 010-8888-8888     | 010-4940-9086     | *
 * | 2022-07-07        | 2022-08-08        | 2022-10-10        | *
 * ============================================================= */
CREATE TABLE DHT11_TEMP_WET_TBL (                      -- 온습도 테이블
	id INT NOT NULL UNIQUE AUTO_INCREMENT PRIMARY KEY, -- 아이디(PK)
	temp INT NULL,                                     -- 온도
	wet INT NULL,                                      -- 습도
    dht11_temp INT NULL,                               -- DHT11 온도
    dht11_wet INT NULL,                                -- DHT11 습도
	date DATETIME NULL                                 -- 연월일시
);
CREATE TABLE RFID_TBL (                                -- RFID 테이블
	id INT NOT NULL UNIQUE AUTO_INCREMENT PRIMARY KEY, -- 아이디(PK)
    rfid VARCHAR(30) NULL,                             -- RFID
    num VARCHAR(12) NULL,                              -- 사번
    name VARCHAR(10) NULL,                             -- 이름
    depart VARCHAR(10) NULL,                           -- 부서
    pos VARCHAR(10) NULL,                              -- 직위
    phone VARCHAR(20) NULL,                            -- 전화번호
    enter_date VARCHAR(20) NULL                        -- 출입일자
);
INSERT INTO RFID_TBL (rfid, num, name, depart, pos, phone, enter_date)
	VALUES ('7C 78 4C 79', '7777777', '칠칠이', '칠성', '계약직', '010-7777-7777', '2022-07-07');
INSERT INTO RFID_TBL (rfid, num, name, depart, pos, phone, enter_date)
	VALUES ('47 1D 95 5F', '88888888', '팔팔이', '팔도', '정규직', '010-8888-8888', '2022-08-08');
SELECT * FROM RFID_TBL;
SELECT * FROM DHT11_TEMP_WET_TBL;