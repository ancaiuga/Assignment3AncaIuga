DELIMITER ;
DELIMITER //
CREATE PROCEDURE DeleteConsultation( idDoctor1 int , idPatient1 int ,consultationDate1  datetime,consultationHour1 int)
begin	
      DELETE from  Consultation
	  WHERE idDoctor = idDoctor1  and idPatient =idPatient1 and consultationDate=consultationDate1 and consultationHour=consultationHour1;
END //
DELIMITER ;