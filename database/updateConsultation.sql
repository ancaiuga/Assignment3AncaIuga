DELIMITER ;
DELIMITER //
CREATE PROCEDURE UpdateConsultation(consultationDate1 datetime,consultationHour1 int,idDoctor1 int,idPatient1 int,details1 varchar(45) )
begin	
       update Consultation set consultationDate=consultationDate1 ,consultationHour=consultationHour1 ,idDoctor=idDoctor1 ,details=details1 
       where idPatient=idPatient1 and consultationDate=consultationDate1 and consultationHour=consultationHour1 and idDoctor=idDoctor1;
END //
DELIMITER ;