package Reserve;

import java.util.Date;

public class Client {
	private String nom, prenom, email, sexe;
	int numetel, numeroCarte, code, age;
	String dateExp;


	public Client(String nom, String prenom,int age, int numetel, int numeroCarte, String dateExp , int code) {
		this.nom = nom;
		this.prenom = prenom;
		this.age=age;
		this.numetel = numetel;
		this.numeroCarte = numeroCarte;
		this.dateExp = dateExp;
		this.code = code;
	}

	public Client() {

	}
	public Client(String nom, String prenom,int age, int numetel ){
		this.nom = nom;
		this.prenom = prenom;
		this.age=age;
		this.numetel = numetel;
	}

	public String getNom() {
		return nom;
	}

	public void setNom(String nom) {
		this.nom = nom;
	}

	public String getPrenom() {
		return prenom;
	}

	public void setPrenom(String prenom) {
		this.prenom = prenom;
	}


	public String getSexe() {
		return sexe;
	}

	public void setSexe(String sexe) {
		this.sexe = sexe;
	}

	public int getNumetel() {
		return numetel;
	}

	public void setNumetel(int numetel) {
		this.numetel = numetel;
	}

	public int getNumeroCarte() {
		return numeroCarte;
	}

	public void setNumeroCarte(int numeroCarte) {
		this.numeroCarte = numeroCarte;
	}

	public int getCode() {
		return code;
	}

	public void setCode(int code) {
		this.code = code;
	}

	public String getDateExp() {
		return dateExp;
	}

	public void setDateExp(String dateExp) {
		this.dateExp = dateExp;
	}

public int getAge(){
	return age;
}
public void setAge(int age){
	this.age=age;
}

}
