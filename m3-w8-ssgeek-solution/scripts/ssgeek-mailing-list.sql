CREATE TABLE job_applications
(
	id			int		identity(1,1)	not null,
	first_name	varchar(64)				not null,
	last_name	varchar(64)				not null,
	state		varchar(50)				not null,
	postal_code	varchar(10)				not null,
	email		varchar(256)			not null,
	
	current_employment_status	varchar(256)	not null,
	last_employer			varchar(256)		not null,
	last_employer_city		varchar(256)		not null,
	last_employer_startdate	date				not null,
	last_employer_enddate	date				not null,


	do_background_check		bit					not null,
	receive_emails			bit					not null,		

	datecreated	datetime				default(getdate())
);

