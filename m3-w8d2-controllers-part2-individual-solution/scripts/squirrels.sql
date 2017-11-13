drop table reviews;

create table reviews
(
	review_id int identity(1,1),
	username varchar(100) not null,
	rating int not null,
	review_title varchar(200) not null,
	review_text varchar(1000) not null,
	review_date datetime default getdate(),

	constraint pk_reviews primary key (review_id)
);

insert into reviews values ('dwintrich', 5, 'My party was a huge success with this book', 'This party could not have taken place without having the cigar parties for dummies book', getdate());
insert into reviews values ('jtucholski', 4, 'No party complete without it', 'There''s no way to hold a succesful party without first looking at this book!', getdate());
insert into reviews values ('ccastelaz', 2, 'Slow read', 'I fell asleep a few times because it was a slow read', getdate());
insert into reviews values ('cborders', 5, 'I knew nothing about squirrel parties', 'After reading this, I am not the master on squirrel parties!', getdate());
