CREATE TABLE pet
(
	pet_id int,
	pet_name varchar(200) not null,
	pet_type varchar(100) not null,
	pet_birthdate datetime,
	owner varchar(200),

	primary key (pet_id)
);


CREATE TABLE pet_visit
(
	pet_id int,
	visitdate datetime,
	procedure_no int,

	primary key (pet_id, visitdate, procedure_no)
);


CREATE TABLE pet_procedures(
	procedure_no int,
	procedure_name varchar(200),

	primary key (procedure_no)
);

ALTER TABLE pet
ADD CONSTRAINT chk_pet_type CHECK (pet_type IN ('Dog', 'Bird', 'Cat', 'Reptile', 'Fish', 'Rodent'));


ALTER TABLE pet_visit
ADD FOREIGN KEY (pet_id) REFERENCES pet(pet_id);


ALTER TABLE pet_visit
ADD FOREIGN KEY (procedure_no) REFERENCES pet_procedures(procedure_no);