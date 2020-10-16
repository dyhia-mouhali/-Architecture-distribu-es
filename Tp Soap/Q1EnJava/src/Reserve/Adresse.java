package Reserve;

public class Adresse {
	private String pays, ville, rue, lieu_dit;
	private int numero;
	

	public Adresse(String pays, String ville, String rue, String lieu_dit, int numero) {

		this.pays = pays;
		this.ville = ville;
		this.rue = rue;
		this.lieu_dit = lieu_dit;
		this.numero = numero;
	

	}

	public Adresse() {

	}

	public String getPays() {
		return pays;
	}

	public void setPays(String pays) {
		this.pays = pays;
	}

	public String getVille() {
		return ville;
	}

	public void setVille(String ville) {
		this.ville = ville;
	}

	public String getRue() {
		return rue;
	}

	public void setRue(String rue) {
		this.rue = rue;
	}

	public String getLieu_dit() {
		return lieu_dit;
	}

	public void setLieu_dit(String lieu_dit) {
		this.lieu_dit = lieu_dit;
	}



	public int getNumero() {
		return numero;
	}

	public void setNumero(int numero) {
		this.numero = numero;
	}

}
