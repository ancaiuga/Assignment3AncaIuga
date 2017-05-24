DELIMITER ;
DELIMITER //
CREATE PROCEDURE UpdateUser(idUser1 int,username1 varchar(45),passwrd1 varchar(45),userType1 int)
begin	
       update Users set username=username1, passwrd=passwrd1,userType=userType1 
       where idUser=idUser1 ;
END //
DELIMITER ;