use baza_danych
create table kategoria
(
	id_kategoria  int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	nazwa varchar(50) NOT NULL,
	typ varchar(50) check (typ='wydatek' or typ='przychod')
)
create table forma_platnosci
(
	id_forma_platnosci int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	nazwa varchar(50) NOT NULL
)
create table role
(
	id_roli int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	nazwa varchar(50) not null,
	opis varchar(500) not null
)


create table uzytkownicy
(
	id_uzytkownika int not null IDENTITY(1,1) PRIMARY KEY,
	imie  varchar(50) not null,
	nazwisko varchar(50) not null,
	email varchar(50) not null, 
	sesja varchar(500), 
	login varchar(50) not null,
	haslo varchar(500) not null,
	id_roli int,
	CONSTRAINT FK_uzytkownik_rola FOREIGN KEY (id_roli) REFERENCES role(id_roli)

)
create table powiadomienia
(
	id_powiadomienia int not null IDENTITY(1,1) PRIMARY KEY,
	id_uzytkownika int,
	nazwa varchar(50) not null,
	opis varchar(50) not null
	CONSTRAINT FK_powiadomienia_uzytkownik FOREIGN KEY (id_uzytkownika) REFERENCES uzytkownicy(id_uzytkownika)
)


create table operacje
(
	id_operacji int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	data DATETIME not null,
	nazwa varchar(50) not null,
	kwota decimal(10,2) NOT NULL,
	id_kategoria int not null,
	id_uzytkownika int not null,
	id_forma_platnosci int,
	cyklicznosc datetime,
	opis varchar(200),
	Zatwierdzone BIT default 'TRUE',
	CONSTRAINT FK_operacja_uzytkownik FOREIGN KEY (id_uzytkownika) REFERENCES uzytkownicy(id_uzytkownika), 
	CONSTRAINT FK_operacja_kategoria FOREIGN KEY (id_kategoria) REFERENCES kategoria(id_kategoria),
	CONSTRAINT FK_operacja_forma_platnosci FOREIGN KEY (id_forma_platnosci) REFERENCES forma_platnosci(id_forma_platnosci)
)
create table sesja_operacja
(
	id_uzytkownika int not null,
	id_operacji int not null,
	data_stworzenia datetime default getdate()
	CONSTRAINT FK_sesja_operacja_uzytkownik FOREIGN KEY (id_uzytkownika) REFERENCES uzytkownicy(id_uzytkownika), 
	CONSTRAINT FK_sesja_operacja_operacja FOREIGN KEY (id_operacji) REFERENCES operacje(id_operacji),
	CONSTRAINT PK_sesja_operacja PRIMARY KEY (id_uzytkownika,id_operacji)
)
create table powiadomienie_odbiorcy
(
	id_uzytkownika int not null,
	id_powiadomienia int not null,
	CONSTRAINT FK_powiadomienie_odbiorcy_uzytkownik FOREIGN KEY (id_uzytkownika) REFERENCES uzytkownicy(id_uzytkownika), 
	CONSTRAINT FK_powiadomienie_odbiorcy_powiadomienie FOREIGN KEY (id_powiadomienia) REFERENCES powiadomienia(id_powiadomienia),
	CONSTRAINT PK_powiadomienie_odbiorcy PRIMARY KEY (id_uzytkownika,id_powiadomienia)
)




ALTER TABLE operacje DROP CONSTRAINT FK_operacja_uzytkownik
ALTER TABLE operacje DROP CONSTRAINT FK_operacja_kategoria
ALTER TABLE operacje DROP CONSTRAINT FK_operacja_forma_platnosci
ALTER TABLE uzytkownicy DROP CONSTRAINT FK_uzytkownik_rola
ALTER TABLE powiadomienia DROP CONSTRAINT FK_powiadomienia_uzytkownik
ALTER TABLE sesja_operacja DROP CONSTRAINT FK_sesja_operacja_uzytkownik
ALTER TABLE sesja_operacja DROP CONSTRAINT FK_sesja_operacja_operacja
ALTER TABLE sesja_operacja DROP CONSTRAINT PK_sesja_operacja
ALTER TABLE sesja_operacja DROP CONSTRAINT FK_powiadomienie_odbiorcy_uzytkownik
ALTER TABLE sesja_operacja DROP CONSTRAINT FK_powiadomienie_odbiorcy_powiadomienie
ALTER TABLE sesja_operacja DROP CONSTRAINT PK_powiadomienie_odbiorcy
drop table operacje
drop table uzytkownicy
drop table forma_platnosci
drop table kategoria
drop table role
drop table powiadomienia
drop table sesja_operacja
drop table uzytkownicy
drop table powiadomienie_odbiorcy


insert into kategoria VALUES('Edukacja','wydatek')
insert into kategoria VALUES('Odzie¿ i dodatki','wydatek')
insert into kategoria VALUES('Rozrywka i wypoczynek','wydatek')
insert into kategoria VALUES('Rachunki','wydatek')
insert into kategoria VALUES('Podatki i op³aty','wydatek')
insert into kategoria VALUES('Transport','wydatek')
insert into kategoria VALUES('Wydatki bie¿¹ce','wydatek')
insert into kategoria VALUES('Wydatki inne','wydatek')


insert into kategoria VALUES('Lokaty i konto oszczêdnoœciowe','przychod')
insert into kategoria VALUES('Oszczêdzanie','przychod')
insert into kategoria VALUES('Wynagrodzenie','przychod')
insert into kategoria VALUES('Wp³ywy inne','przychod')

insert into forma_platnosci Values('Gotówka')
insert into forma_platnosci Values('Przelew')
insert into forma_platnosci Values('Karta')

insert into role VALUES('Administrator','Ma prawo wydatki i przychody z grupy U¿ytkowników. Wys³aæ proœby do moderatora o dodanie wydatku albo przychodu. Jest uprawniony do dodawania, edytowania i usuwania w³asnych wydatków i przychodów. Jest upowa¿niony równie¿ do edytowania i usuwania wydatków i przychodów innych u¿ytkowników. Posiada mo¿liwoœæ dodawania, edytowania i usuwania wydatków i przychodów na proœbê obserwatorów. Ma prawo do dodawania oraz usuwania u¿ytkowników z systemu oraz do zarz¹dzania uprawieniami u¿ytkowników.')
insert into role VALUES('Moderator','Ma prawo wydatki i przychody z grupy U¿ytkowników. Wys³aæ proœby do moderatora o dodanie wydatku albo przychodu. Jest uprawniony do dodawania, edytowania i usuwania w³asnych wydatków i przychodów. Jest upowa¿niony równie¿ do edytowania i usuwania wydatków i przychodów innych u¿ytkowników. Posiada mo¿liwoœæ dodawania, edytowania i usuwania wydatków i przychodów na proœbê obserwatorów.')
insert into role VALUES('Obserwator','Ma prawo do obserwowania wydatków i przychodów z grupy U¿ytkowników. Wysy³aæ proœby do moderatora o dodanie wydatku lub przychodu.')
insert into role VALUES('U¿ytkownik','Ma prawo wydatki i przychody z grupy U¿ytkowników. Wys³aæ proœby do moderatora o dodanie wydatku albo przychodu. Jest uprawniony do dodawania, edytowania i usuwania w³asnych wydatków i przychodów.')
