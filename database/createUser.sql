DELIMITER ;
DELIMITER //
CREATE PROCEDURE CreateUser(idUser1 int,username1 varchar(45),passwrd1 varchar(45),userType1 int)
begin	
       Insert into  Users(idUser, username,passwrd, userType) VALUES (idUser1, username1,passwrd1, userType1);
END //
DELIMITER ;