#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: role
#------------------------------------------------------------

CREATE TABLE role(
        ID_Compositeur Int  Auto_increment  NOT NULL ,
        nomCompositeur Varchar (50) NOT NULL
	,PRIMARY KEY (ID_Compositeur)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: star
#------------------------------------------------------------

CREATE TABLE star(
        idstar        Int  Auto_increment  NOT NULL ,
        prenom        Varchar (50) NOT NULL ,
        datenaissance Datetime NOT NULL ,
        paysorigine   Varchar (50) NOT NULL ,
        nom           Varchar (50) NOT NULL
	,INDEX (nom)
	,PRIMARY KEY (idstar)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: lieu
#------------------------------------------------------------

CREATE TABLE lieu(
        idlieu  Int  Auto_increment  NOT NULL ,
        nomLieu Varchar (50) NOT NULL
	,PRIMARY KEY (idlieu)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: typedocument
#------------------------------------------------------------

CREATE TABLE typedocument(
        codeTypeDocument Varchar (3) NOT NULL ,
        typeNom          Varchar (50) NOT NULL
	,PRIMARY KEY (codeTypeDocument)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: document
#------------------------------------------------------------

CREATE TABLE document(
        codedocument     Varchar (6) NOT NULL ,
        titre_document   Varchar (50) NOT NULL ,
        codeTypeDocument Varchar (3) NOT NULL
	,PRIMARY KEY (codedocument)

	,FOREIGN KEY (codeTypeDocument) REFERENCES typedocument(codeTypeDocument)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: civilite
#------------------------------------------------------------

CREATE TABLE civilite(
        idcivil Int  Auto_increment  NOT NULL ,
        libelle Varchar (20) NOT NULL
	, PRIMARY KEY (idcivil)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: pays
#------------------------------------------------------------

CREATE TABLE pays(
        idpays  Int  Auto_increment  NOT NULL ,
        libelle Varchar (5) NOT NULL
	,PRIMARY KEY (idpays)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: codepostal
#------------------------------------------------------------

CREATE TABLE codepostal(
        idcp    Int  Auto_increment  NOT NULL ,
        libelle Varchar (5) NOT NULL ,
        idpays  Int NOT NULL
	,PRIMARY KEY (idcp)

	,FOREIGN KEY (idpays) REFERENCES pays(idpays)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: ville
#------------------------------------------------------------

CREATE TABLE ville(
        idville Int  Auto_increment  NOT NULL ,
        libelle Varchar (50) NOT NULL ,
        idcp    Int NOT NULL
	,PRIMARY KEY (idville)

	,FOREIGN KEY (idcp) REFERENCES codepostal(idcp)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: adherent
#------------------------------------------------------------

CREATE TABLE adherent(
        code      Varchar (4) NOT NULL ,
        nom       Varchar (50) NOT NULL ,
        prenom    Varchar (50) NOT NULL ,
        adresse1  Varchar (50) NOT NULL ,
        adresse2  Varchar (50) NOT NULL ,
        refmoral  Varchar (50) NOT NULL ,
        email     Varchar (50) NOT NULL ,
        telephone Varchar (10) NOT NULL ,
        idville   Int NOT NULL ,
        idcivil   Int NOT NULL
	,PRIMARY KEY (code)

	,FOREIGN KEY (idville) REFERENCES ville(idville)
	,FOREIGN KEY (idcivil) REFERENCES civilite(idcivil)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: etat
#------------------------------------------------------------

CREATE TABLE etat(
        code    Varchar (1) NOT NULL ,
        libelle Varchar (20) NOT NULL
	,PRIMARY KEY (code)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: unitevente
#------------------------------------------------------------

CREATE TABLE unitevente(
        idunite Int  Auto_increment  NOT NULL ,
        libelle Varchar (20) NOT NULL
	,PRIMARY KEY (idunite)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: tarif
#------------------------------------------------------------

CREATE TABLE tarif(
        idtarif      Int  Auto_increment  NOT NULL ,
        prixunitaire Float NOT NULL ,
        idunite      Int NOT NULL
	,PRIMARY KEY (idtarif)

	,FOREIGN KEY (idunite) REFERENCES unitevente(idunite)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: support
#------------------------------------------------------------

CREATE TABLE support(
        codesupport    Varchar (3) NOT NULL ,
        libellesupport Varchar (50) NOT NULL ,
        idtarif        Int NOT NULL
	,PRIMARY KEY (codesupport)

	, FOREIGN KEY (idtarif) REFERENCES tarif(idtarif)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: exemplaire
#------------------------------------------------------------

CREATE TABLE exemplaire(
        numero_exemplaire Varchar (2) NOT NULL ,
        codesupport       Varchar (3) NOT NULL ,
        codedocument      Varchar (6) NOT NULL ,
        code              Varchar (1) NOT NULL
	,PRIMARY KEY (numero_exemplaire,codedocument)

	,FOREIGN KEY (codesupport) REFERENCES support(codesupport)
	, FOREIGN KEY (codedocument) REFERENCES document(codedocument)
	,FOREIGN KEY (code) REFERENCES etat(code)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: taxe_planetaire
#------------------------------------------------------------

CREATE TABLE taxe_planetaire(
        id_tva  Int  Auto_increment  NOT NULL ,
        taux    Float NOT NULL ,
        libelle Varchar (20) NOT NULL
	,PRIMARY KEY (id_tva)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: facture
#------------------------------------------------------------

CREATE TABLE facture(
        idfacture Int  Auto_increment  NOT NULL ,
        code      Varchar (4) NOT NULL ,
        id_tva    Int NOT NULL
	,CONSTRAINT facture_PK PRIMARY KEY (idfacture)

	,FOREIGN KEY (code) REFERENCES adherent(code)
	,FOREIGN KEY (id_tva) REFERENCES taxe_planetaire(id_tva)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: location
#------------------------------------------------------------

CREATE TABLE location(
        idlocation        Int  Auto_increment  NOT NULL ,
        datelocation      Date NOT NULL ,
        dateretour        Date NOT NULL ,
        numero_exemplaire Varchar (2) NOT NULL ,
       codedocument      Varchar (6) NOT NULL ,
        code              Varchar (4) NOT NULL ,
        idfacture         Int NOT NULL
	,CONSTRAINT location_PK PRIMARY KEY (idlocation)

	,FOREIGN KEY (numero_exemplaire,codedocument) REFERENCES exemplaire(numero_exemplaire,codedocument)
	, FOREIGN KEY (code) REFERENCES adherent(code)
	,FOREIGN KEY (idfacture) REFERENCES facture(idfacture)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: participer
#------------------------------------------------------------

CREATE TABLE participer(
        codedocument   Varchar (6) NOT NULL ,
        idstar         Int NOT NULL ,
        ID_Compositeur Int NOT NULL
	,PRIMARY KEY (codedocument,idstar,ID_Compositeur)

	,FOREIGN KEY (codedocument) REFERENCES document(codedocument)
	, FOREIGN KEY (idstar) REFERENCES star(idstar)
	, FOREIGN KEY (ID_Compositeur) REFERENCES role(ID_Compositeur)
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: tourner
#------------------------------------------------------------

CREATE TABLE tourner(
        idlieu       Int NOT NULL ,
        codedocument Varchar (6) NOT NULL
	,CONSTRAINT tourner_PK PRIMARY KEY (idlieu,codedocument)

	,FOREIGN KEY (idlieu) REFERENCES lieu(idlieu)
	,FOREIGN KEY (codedocument) REFERENCES document(codedocument)
)ENGINE=InnoDB;

