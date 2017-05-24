DELIMITER ;
DELIMITER //
CREATE PROCEDURE CreatePatient(idPatient1 int,patientName1 varchar(45),identityCardNumber1 varchar(45),cnp1 varchar(45),birthDate1 date,address1 varchar(45))
begin	
       Insert into  Patient(idPatient ,patientName ,identityCardNumber , cnp ,birthDate,address ) VALUES (idPatient1 ,patientName1 ,identityCardNumber1 , cnp1 ,birthDate1,address1 );
END //
DELIMITER ;