
  CREATE TABLE "ST"."TASK_ORDER" 
   (	"ORDER_ID" VARCHAR2(100 BYTE) NOT NULL DISABLE, 
	"SOURCE" VARCHAR2(20 BYTE), 
	"CREATE_DATE" DATE, 
	"PRODUCT_NAME" VARCHAR2(100 BYTE), 
	"PRODUCT_TYPE" VARCHAR2(100 BYTE), 
	"START_DATE" DATE, 
	"END_DATE" DATE, 
	"LEFT_TOP_LON" VARCHAR2(20 BYTE), 
	"LEFT_TOP_LAT" VARCHAR2(20 BYTE), 
	"RIGHT_BOTTOM_LON" VARCHAR2(20 BYTE), 
	"RIGHT_BOTTOM_LAT" VARCHAR2(20 BYTE), 
	"CREATEDAT" DATE, 
	"CREATEDBY" VARCHAR2(50 BYTE), 
	"LASTUPDATEDAT" DATE, 
	"LASTUPDATEDBY" VARCHAR2(50 BYTE), 
	"DELETEDAT" DATE, 
	"DELETEDBY" VARCHAR2(50 BYTE), 
	"TIMESTAMP" TIMESTAMP (6), 
	"ISDELETED" NUMBER(1,0), 
	"TASK_ORDER_ID" VARCHAR2(100 BYTE) NOT NULL ENABLE
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
 

  CREATE UNIQUE INDEX "ST"."task_order_PK" ON "ST"."TASK_ORDER" ("ORDER_ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
 

  CREATE OR REPLACE TRIGGER "ST"."TASK_ORDER_TR" 
BEFORE INSERT ON TASK_ORDER 
for each row
BEGIN
 select TASK_ORDER_SEQ.nextval into :new.ORDER_ID from dual;
END;
/
ALTER TRIGGER "ST"."TASK_ORDER_TR" ENABLE;
 