package Reserve;

import java.util.ArrayList;

public class Hotel {

	public String nom;
	public Adresse adresse;
	public int nombreEtoile;
	public ArrayList<Chambre> chambres = null;
   // ArrayList< Chambre> chambres = null;


	public Hotel(String nom, Adresse adresse, int nombreEtoile) {

		this.nom = nom;
		this.adresse = adresse;
		this.nombreEtoile = nombreEtoile;
		this.chambres = new ArrayList();
	}

	public String getNom() {
		return nom;
	}

	public void setNom(String nom) {
		this.nom = nom;
	}

	public Adresse getAdresse() {
		return adresse;
	}

	public void setAdresse(Adresse adresse) {
		this.adresse = adresse;
	}

	public int getNombreEtoile() {
		return nombreEtoile;
	}

	public void setNombreEtoile(int nombreEtoile) {
		this.nombreEtoile = nombreEtoile;
	}

	public ArrayList getChambres() {
		return chambres;
	}

	public void setChambes(ArrayList chambres) {
		this.chambres = chambres;
	}

	public Hotel() {
	}
public Boolean addChambre(Chambre chambre){
	if(chambres.add(chambre)){
	return true;
	}
	return true;
}
}
