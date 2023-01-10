create database krushiKart;

use krushiKart;

create table products(ProdId INT NOT NULL PRIMARY KEY AUTO_INCREMENT,ProdTitle VARCHAR(50),ProdCategory VARCHAR(50),ProdDesc VARCHAR(100),ProdPrice DECIMAL(9,2),ProdQty INT);

CREATE TABLE categories(categoryid INT NOT NULL AUTO_INCREMENT PRIMARY KEY, title VARCHAR(50) NOT NULL);
-- CREATE TABLE accounts(accountid  INT NOT NULL PRIMARY KEY AUTO_INCREMENT,accHldrFName VARCHAR(15),accHldrFName VARCHAR(15),contactNo VARCHAR(15), balance FLOAT,);
CREATE TABLE carts(cartid INT NOT NULL PRIMARY KEY AUTO_INCREMENT, cartdate DATETIME NOT NULL, subtotal FLOAT);

CREATE TABLE users(userid INT NOT NULL PRIMARY KEY AUTO_INCREMENT,password VARCHAR(100) NOT NULL,question VARCHAR(255),answer VARCHAR(255), roleid  int,
		   CONSTRAINT fk_userroles FOREIGN KEY(roleid) REFERENCES roles(roleid));

           
CREATE TABLE shippers(shipperid INT NOT NULL PRIMARY KEY AUTO_INCREMENT,userid INT NOT NULL,
                       email VARCHAR(200) NOT NULL, contactnumber VARCHAR(10) NOT NULL,address VARCHAR(100), organization VARCHAR(50),
						CONSTRAINT fk_usersshippers FOREIGN KEY(userid) REFERENCES users(userid));

CREATE TABLE suppliers(supplierid INT NOT NULL AUTO_INCREMENT PRIMARY KEY,organization VARCHAR(100) NOT NULL,location VARCHAR(100) NOT NULL,
		        email VARCHAR(50) NOT NULL,contactnumber VARCHAR(10) NOT NULL, discounttype VARCHAR(50) NOT NULL,
				accountid INT NOT NULL,
                userid INT NOT NULL,
                CONSTRAINT fk_supplierusers FOREIGN KEY(userid) REFERENCES users(userid),
			    CONSTRAINT fk_supplieraccounts FOREIGN KEY(accountid) REFERENCES accounts(accountid));


CREATE TABLE customers(customerid INT NOT NULL PRIMARY KEY AUTO_INCREMENT,firstname VARCHAR(50) NOT NULL,lastname VARCHAR(50),
			email VARCHAR(100) NOT NULL,contactnumber VARCHAR(13),address VARCHAR(255),
            roleid INT NOT NULL, accountid INT NOT NULL,userid INT NOT NULL,
            CONSTRAINT fk_customersusers FOREIGN KEY(userid) REFERENCES users(userid),
			CONSTRAINT fk_customeraccounts FOREIGN KEY(accountid) REFERENCES accounts(accountid),
            CONSTRAINT fk_customersroles FOREIGN KEY(roleid) REFERENCES roles(roleid));

CREATE TABLE orders (orderid INT NOT NULL PRIMARY KEY AUTO_INCREMENT, orderdate DATETIME NOT NULL, status VARCHAR(20), customerid INT NOT NULL,
			CONSTRAINT fk_orderscustomers FOREIGN KEY(customerid) REFERENCES customers(customerid));

CREATE TABLE cartdetails(cartdetailid INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
						cartid INT NOT NULL, productid INT NOT NULL, quantity INT NOT NULL, 
						CONSTRAINT fk_cartscartdetails FOREIGN KEY(cartid) REFERENCES carts(cartid),
                        CONSTRAINT fk_productscartdetails FOREIGN KEY(productid) REFERENCES products(productid));

CREATE TABLE orderdetails (orderdetailid INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
			  orderid INT NOT NULL, productid INT NOT NULL, quantity INT,
			  CONSTRAINT fk_orderdetailsorders FOREIGN KEY (orderid) REFERENCES orders(orderid),
              CONSTRAINT fk_orderdetailsproducts FOREIGN KEY (productid) REFERENCES products(productid));

CREATE TABLE deliveries(deliveryid INT NOT NULL PRIMARY KEY AUTO_INCREMENT, status VARCHAR(200) NOT NULL, orderid INT NOT NULL,shipperid INT NOT NULL,
			CONSTRAINT fk_deliveryorders FOREIGN KEY(orderid) REFERENCES orders(orderid),
			CONSTRAINT fk_deliveryshippers FOREIGN KEY(shipperid) REFERENCES shippers(shipperid));


INSERT INTO products(ProdTitle,ProdCategory,ProdDesc,ProdPrice,ProdQty)
values ("Tomato Seed","Seeds","Hybrid red tomato seeds",1200,15);

INSERT INTO products(ProdTitle,ProdCategory,ProdDesc,ProdPrice,ProdQty)
values ("Soyabin Seed","Seeds","Hybrid Soyabin 632no seeds",3200,15);

INSERT INTO products(ProdTitle,ProdCategory,ProdDesc,ProdPrice,ProdQty)
values ("Carrot Seed","Seeds","New viraty of carrot seeds",1500,8);

INSERT INTO products(ProdTitle,ProdCategory,ProdDesc,ProdPrice,ProdQty)
values ("Pomigrade Seed","Seeds","Hybrid Pomigrade with good qulity seeds",500,15);

INSERT INTO products(ProdTitle,ProdCategory,ProdDesc,ProdPrice,ProdQty)
values ("12-32-16","Fertlize","NPK 12-32-16 is a DAP based composite fertiliser and is produced at IFFCOs",1600,15);

