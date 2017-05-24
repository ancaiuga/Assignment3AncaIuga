DELIMITER ;
DELIMITER //
CREATE PROCEDURE DeleteUser(idUser int )
begin	
      DELETE from  Users
	  WHERE idUser=users.idUser;
END //
DELIMITER ;