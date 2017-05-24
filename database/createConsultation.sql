DELIMITER ;
DELIMITER //
CREATE PROCEDURE CreateConsultation(consultationDate1 datetime,consultationHour1 int,idDoctor1 int,idPatient1 int,details1 varchar(45))
begin	
       Insert into  Consultation(consultationDate,consultationHour,idDoctor,idPatient,details) VALUES (consultationDate1,consultationHour1,idDoctor1,idPatient1,details1);
END //
DELIMITER ;