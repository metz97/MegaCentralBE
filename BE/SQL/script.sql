CREATE TABLE ms_storage_location (
    location_id varchar(10) NOT NULL PRIMARY KEY,
    location_name varchar(100) NOT NULL,
);

CREATE TABLE tr_bpkb (
    agreement_number varchar(100) NOT NULL PRIMARY KEY,
    bpkb_no varchar(100) NOT NULL,
	branch_id varchar(10) NOT NULL,
	bpkb_date datetime NOT NULL,
	faktur_no varchar(100) NOT NULL,
	faktur_date datetime NOT NULL,
	location_id varchar(10) FOREIGN KEY REFERENCES ms_storage_location(location_id) NOT NULL,
	police_no varchar(20) NOT NULL,
	bpkb_date_in datetime NOT NULL,
);