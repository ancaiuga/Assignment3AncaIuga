DELIMITER ;
DELIMITER //
CREATE PROCEDURE UpdatePatient(idPatient1 int,patientName1 varchar(45),identityCardNumber1 varchar(45),cnp1 varchar(45),birthDate1 date,address1 varchar(45))
begin	
       update Patient set patientName=patientName1 ,identityCardNumber=identityCardNumber1 ,cnp=cnp1 ,birthDate=birthDate1 ,address=address1
       where idPatient=idPatient1 ;
END //
DELIMITER ;