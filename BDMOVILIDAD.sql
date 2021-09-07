﻿CREATE DATABASE BDMOVILIDAD
GO
USE BDMOVILIDAD
GO
CREATE TABLE MODULO_ORIGEN(
    MODULO_ID INTEGER PRIMARY KEY NOT NULL IDENTITY(1,1),
    LOCAL VARCHAR(50) NOT NULL,
    DIRECCION VARCHAR(255) NOT NULL
)
GO
CREATE TABLE MODULO_DESTINO(
    MODULO_ID INTEGER PRIMARY KEY NOT NULL IDENTITY(1,1),
    LOCAL VARCHAR(50) NOT NULL,
    DIRECCION VARCHAR(255) NOT NULL
)
GO
CREATE TABLE USUARIO(
    USUARIO_ID INTEGER PRIMARY KEY NOT NULL IDENTITY(1,1),
    NOMBRES VARCHAR(100),
    DNI VARCHAR(8),
)
GO
CREATE TABLE REPORTES(
    REPORTE_ID INTEGER PRIMARY KEY NOT NULL IDENTITY(1,1),
    FECHA DATE,
    USUARIO_ID INTEGER FOREIGN KEY REFERENCES USUARIO(USUARIO_ID)
)
GO

CREATE TABLE VIAJES(
    VIAJE_ID INTEGER PRIMARY KEY NOT NULL IDENTITY(1,1),
    FECHA DATE NOT NULL,
    TIPO VARCHAR(10) NOT NULL,
    MODULO_ORIGEN INTEGER FOREIGN KEY REFERENCES MODULO_ORIGEN(MODULO_ID) NOT NULL,
    MODULO_DESTINO INTEGER FOREIGN KEY REFERENCES MODULO_DESTINO(MODULO_ID) NOT NULL,
    MOTIVO VARCHAR(255) NOT NULL,
    MONTO DECIMAL(5,2) NOT NULL,
    REPORTE_ID INTEGER FOREIGN KEY REFERENCES REPORTES(REPORTE_ID)
)
GO




INSERT INTO MODULO_ORIGEN(LOCAL,DIRECCION) VALUES ('Oficina','CALLE HUINCO 139, SAN MIGUEL')
INSERT INTO MODULO_ORIGEN(LOCAL,DIRECCION) VALUES ('Plaza San Miguel','AV. LA MARINA NRO 2000, SAN MIGUEL')
INSERT INTO MODULO_ORIGEN(LOCAL,DIRECCION) VALUES ('Mall Bellavista','AV. OSCAR R. BENAVIDES NRO. 3866, CALLAO')
INSERT INTO MODULO_ORIGEN(LOCAL,DIRECCION) VALUES ('Plaza Norte','Av. Alfredo Mendiola N° 1400, INDEPENDENCIA')
INSERT INTO MODULO_ORIGEN(LOCAL,DIRECCION) VALUES ('Real Centro Civico','AV. GARCILASO DE LA VEGA NRO. 1337 INT. 2047 LIMA')
INSERT INTO MODULO_ORIGEN(LOCAL,DIRECCION) VALUES ('Open Angamos','AV. ANGAMOS NRO. 1803, SURQUILLO')
INSERT INTO MODULO_ORIGEN(LOCAL,DIRECCION) VALUES ('Jockey Plaza','AV. JAVIER PRADO ESTE NRO. 4200, SANTIAGO DE SURCO')
INSERT INTO MODULO_ORIGEN(LOCAL,DIRECCION) VALUES ('Mall Santa Anita','AV. CARRETERA CENTRAL NRO. 111, SANTA ANITA')
INSERT INTO MODULO_ORIGEN(LOCAL,DIRECCION) VALUES ('San Borja','AV. JAVIER PRADO ESTE 2050, SAN BORJA')
INSERT INTO MODULO_ORIGEN(LOCAL,DIRECCION) VALUES ('Plaza Lima Sur','AV. PRLG. PASEO DE LA REPUBLICA 355, CHORRILLOS')
INSERT INTO MODULO_ORIGEN(LOCAL,DIRECCION) VALUES ('Real Salaverry','AV. GENERAL FELIPE SALAVERRY NRO. 2370, JESUS MARIA')
INSERT INTO MODULO_ORIGEN(LOCAL,DIRECCION) VALUES ('Brasil','AV. BRASIL NRO. 714, BREÑA ')
INSERT INTO MODULO_ORIGEN(LOCAL,DIRECCION) VALUES ('Jockey Financiero','AV. JAVIER PRADO ESTE NRO. 4200, SANTIAGO DE SURCO')
INSERT INTO MODULO_ORIGEN(LOCAL,DIRECCION) VALUES ('Mall del Sur ','AV. LOS LIRIOS 301')
INSERT INTO MODULO_ORIGEN(LOCAL,DIRECCION) VALUES ('Mega Plaza','AV. ALFREDO MENDIOLA 3698, INDEPENDENCIA')

GO
INSERT INTO MODULO_DESTINO(LOCAL,DIRECCION) VALUES ('Oficina','CALLE HUINCO 139, SAN MIGUEL')
INSERT INTO MODULO_DESTINO(LOCAL,DIRECCION) VALUES ('Plaza San Miguel','AV. LA MARINA NRO 2000, SAN MIGUEL')
INSERT INTO MODULO_DESTINO(LOCAL,DIRECCION) VALUES ('Mall Bellavista','AV. OSCAR R. BENAVIDES NRO. 3866, CALLAO')
INSERT INTO MODULO_DESTINO(LOCAL,DIRECCION) VALUES ('Plaza Norte','Av. Alfredo Mendiola N° 1400, INDEPENDENCIA')
INSERT INTO MODULO_DESTINO(LOCAL,DIRECCION) VALUES ('Real Centro Civico','AV. GARCILASO DE LA VEGA NRO. 1337 INT. 2047 LIMA')
INSERT INTO MODULO_DESTINO(LOCAL,DIRECCION) VALUES ('Open Angamos','AV. ANGAMOS NRO. 1803, SURQUILLO')
INSERT INTO MODULO_DESTINO(LOCAL,DIRECCION) VALUES ('Jockey Plaza','AV. JAVIER PRADO ESTE NRO. 4200, SANTIAGO DE SURCO')
INSERT INTO MODULO_DESTINO(LOCAL,DIRECCION) VALUES ('Mall Santa Anita','AV. CARRETERA CENTRAL NRO. 111, SANTA ANITA')
INSERT INTO MODULO_DESTINO(LOCAL,DIRECCION) VALUES ('San Borja','AV. JAVIER PRADO ESTE 2050, SAN BORJA')
INSERT INTO MODULO_DESTINO(LOCAL,DIRECCION) VALUES ('Plaza Lima Sur','AV. PRLG. PASEO DE LA REPUBLICA 355, CHORRILLOS')
INSERT INTO MODULO_DESTINO(LOCAL,DIRECCION) VALUES ('Real Salaverry','AV. GENERAL FELIPE SALAVERRY NRO. 2370, JESUS MARIA')
INSERT INTO MODULO_DESTINO(LOCAL,DIRECCION) VALUES ('Brasil','AV. BRASIL NRO. 714, BREÑA ')
INSERT INTO MODULO_DESTINO(LOCAL,DIRECCION) VALUES ('Jockey Financiero','AV. JAVIER PRADO ESTE NRO. 4200, SANTIAGO DE SURCO')
INSERT INTO MODULO_DESTINO(LOCAL,DIRECCION) VALUES ('Mall del Sur ','AV. LOS LIRIOS 301')
INSERT INTO MODULO_DESTINO(LOCAL,DIRECCION) VALUES ('Mega Plaza','AV. ALFREDO MENDIOLA 3698, INDEPENDENCIA')

GO

INSERT INTO USUARIO(NOMBRES,DNI) VALUES ('ENRIQUE SAENZ HIGINIO','76742891')

GO


--exec SP_MOSTRAR_DNI 1


CREATE PROC SP_CREAR
		@USUARIO_ID INTEGER,
		@NOMBRE VARCHAR(100),
		@DNI VARCHAR(8),
		@OPCION CHAR(7)

AS BEGIN

		IF (@OPCION = 'USUARIO') BEGIN

		INSERT INTO USUARIO(NOMBRES,DNI) VALUES (@NOMBRE,@DNI)
		
		END
		IF (@OPCION = 'REPORTE') BEGIN
		INSERT INTO REPORTES(FECHA,USUARIO_ID) VALUES (GETDATE(),@USUARIO_ID)
		END
END
GO
--EXEC SP_CRUD_VIAJE 0,0,0,0,0,'','',0.0,'','R'

CREATE PROC SP_CRUD_VIAJE
	@VIAJE_ID INTEGER,
    @USUARIO_ID INTEGER,
	@REPORTE_ID INTEGER,
	@ID_ORIGEN INTEGER,
	@ID_DESTINO INTEGER,
	@TIPO_VIAJE VARCHAR(10),
	@FECHA_VIAJE DATE,
	@MONTO DECIMAL(5,2),
	@MOTIVO VARCHAR(255),
	@OPTION CHAR(1)
AS BEGIN

	IF (@OPTION = 'C') BEGIN
		
		INSERT INTO VIAJES(FECHA,MODULO_ORIGEN,MODULO_DESTINO,TIPO,MONTO,MOTIVO,REPORTE_ID)
		VALUES (@FECHA_VIAJE,@ID_ORIGEN,@ID_DESTINO,@TIPO_VIAJE,@MONTO,@MOTIVO,IDENT_CURRENT('REPORTES'))
	END
	IF (@OPTION = 'R') BEGIN
	
		SELECT 
		ROW_NUMBER() OVER (ORDER BY V.fecha ) as ID,
		V.FECHA,V.MOTIVO,V.TIPO,
		( MO.DIRECCION ) AS ORIGEN,
		( MD.DIRECCION) AS DESTINO,
		V.MONTO
	FROM MODULO_ORIGEN MO,MODULO_DESTINO MD, VIAJES V, REPORTES R
	WHERE V.REPORTE_ID = R.REPORTE_ID 
				AND
		MO.MODULO_ID = V.MODULO_ORIGEN
				AND 
		 MD.MODULO_ID = V.MODULO_DESTINO
				AND
			  R.REPORTE_ID = IDENT_CURRENT('REPORTES')

	END
	IF (@OPTION = 'U') BEGIN
			UPDATE VIAJES SET FECHA=@FECHA_VIAJE,MODULO_ORIGEN=@ID_ORIGEN,MODULO_DESTINO=@ID_DESTINO,TIPO=@TIPO_VIAJE,MONTO=@MONTO,MOTIVO=@MOTIVO WHERE VIAJE_ID = @VIAJE_ID
	END
	IF (@OPTION = 'D') BEGIN
			DELETE FROM VIAJES WHERE VIAJE_ID = @VIAJE_ID
	END
END
GO

CREATE PROC SP_MOSTRAR_DNI
		@USUARIO_ID INTEGER
AS BEGIN

	select DNI from USUARIO where USUARIO_ID =  @USUARIO_ID

END
GO

CREATE  PROC SP_MOSTRAR_TOTAL
	@REPORTE_ID INTEGER
AS BEGIN

		SELECT SUM(Monto) TOTAL FROM VIAJES WHERE REPORTE_ID = IDENT_CURRENT('REPORTES')
END

GO












-------------------------------------------------






