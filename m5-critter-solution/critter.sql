DROP TABLE message;
DROP TABLE app_user;

CREATE TABLE app_user (
  user_name varchar(32) NOT NULL,     -- Username
  password varchar(32) NOT NULL,      -- Password (in plain-text)
  salt varchar(32) not null,
  avatar_id integer,                  -- Avatar Number (optional?)
  CONSTRAINT pk_app_user_username PRIMARY KEY (user_name)
);

CREATE TABLE message (
  message_id integer identity NOT NULL,
  sender_name varchar(32) NOT NULL,
  private bit NOT NULL DEFAULT 0,
  receiver_name varchar(32),
  message_text varchar(200) NOT NULL,
  create_date DATETIME NOT NULL DEFAULT dateadd(hour, -6, GETDATE()),
  CONSTRAINT pk_message_message_id PRIMARY KEY (message_id)
);

ALTER TABLE message ADD FOREIGN KEY (sender_name) REFERENCES app_user(user_name);

ALTER TABLE message ADD FOREIGN KEY (receiver_name) REFERENCES app_user(user_name);


INSERT INTO app_user VALUES ('ccastelaz', 'njFhg04/TvFSWgvIifneGysdclA=', 'jXpx1CUFGwk=', 0);
INSERT INTO app_user VALUES ('chatters', 'njFhg04/TvFSWgvIifneGysdclA=',  'jXpx1CUFGwk=', 0);
INSERT INTO app_user VALUES ('curly', 'njFhg04/TvFSWgvIifneGysdclA=',  'jXpx1CUFGwk=', 0);
INSERT INTO app_user VALUES ('dwintrich', 'njFhg04/TvFSWgvIifneGysdclA=',  'jXpx1CUFGwk=', 0);
INSERT INTO app_user VALUES ('jtucholski', 'njFhg04/TvFSWgvIifneGysdclA=',  'jXpx1CUFGwk=', 0);
INSERT INTO app_user VALUES ('moe', 'njFhg04/TvFSWgvIifneGysdclA=',  'jXpx1CUFGwk=', 0);
INSERT INTO app_user VALUES ('nutterbutter', 'njFhg04/TvFSWgvIifneGysdclA=',  'jXpx1CUFGwk=', 0);
INSERT INTO app_user VALUES ('nutz', 'njFhg04/TvFSWgvIifneGysdclA=',  'jXpx1CUFGwk=', 0);
INSERT INTO app_user VALUES ('oscar', 'njFhg04/TvFSWgvIifneGysdclA=',  'jXpx1CUFGwk=', 0);
INSERT INTO app_user VALUES ('squirrely_joe', 'njFhg04/TvFSWgvIifneGysdclA=',  'jXpx1CUFGwk=', 0);
INSERT INTO app_user VALUES ('twiggy', 'njFhg04/TvFSWgvIifneGysdclA=',  'jXpx1CUFGwk=', 0);

INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('chatters', 0, NULL, 'Squeak, squeak!');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('jtucholski', 1, 'ccastelaz', 'Is there a squirrel party this weekend?');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('dwintrich', 1, 'ccastelaz', 'Do you need any cigars?');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('ccastelaz', 1, 'jtucholski', 'Yep, are you able to make it?');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('ccastelaz', 1, 'dwintrich', 'Nope, I''ve got about 45, should be a good time');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('dwintrich', 1, 'ccastelaz', 'Ok I cant wait!');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('chatters', 0, NULL, 'Anyone out there?');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('jtucholski', 0, NULL, 'Looking forward to squirrel party this weekend!');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('ccastelaz', 0, NULL, 'Heading out for some cigars, need about 45 of them for a good weekend.');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('jtucholski', 1, 'ccastelaz', 'I should not have a problem being there!');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('ccastelaz', 1, 'jtucholski', 'Great! dwintrich is coming too!');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('jtucholski', 1, 'ccastelaz', 'Great! What are we eating?');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('jtucholski', 1, 'ccastelaz', 'Because I wanted to eat some Thai food');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('jtucholski', 1, 'dwintrich', 'Heard you will be at the party this weekend?');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('ccastelaz', 1, 'jtucholski', 'Yes there will be Thai food');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('curly', 0, NULL, 'Just chillin...');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('curly', 0, NULL, 'I really with there was some other place we could talk about jtucholski');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('curly', 0, NULL, 'Whoops was that public? How do you delete again?');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('twiggy', 0, NULL, 'I wish Alvin was on Chatter...');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('twiggy', 1, 'jtucholski', 'Do you know if Alvin is on Chatter?');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('twiggy', 1, 'jtucholski', 'Do''t know if you saw my message, but trying to find Alvin, Simon, or Theo..');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('twiggy', 1, 'jtucholski', 'I know you are ignoring me, but still here. Txt you have my digits!');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('nutterbutter', 0, NULL, 'In the mood for a nutter butter. Anyone know the keeblrer elves account?');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('squirrely_joe', 0, NULL, 'Just broke out of the clink, what is this thing called Chatter?');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('dwintrich', 1, 'squirrely_joe', 'Hey we use Chatter to talk to eachc other and also about jtucholski');
INSERT INTO message (sender_name, private, receiver_name, message_text) VALUES ('jtucholski', 0, NULL, 'I feel like I am just talking to myself??!!');



