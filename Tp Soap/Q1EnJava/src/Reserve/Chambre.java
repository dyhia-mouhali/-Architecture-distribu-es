package Reserve;

import java.util.Date;

public class Chambre {
	
	private TypeChambre typeChambre;
	private Date dateDebutDisponibilite;
	private Date dateFinDisponibilite;
	Boolean diponibilite;

	public Chambre(TypeChambre typeChambre, Date dateDebutDisponibilite, Date dateFinDisponibilite) {
		super();
		this.typeChambre = typeChambre;
		this.dateDebutDisponibilite = dateDebutDisponibilite;
		this.dateFinDisponibilite = dateFinDisponibilite;

		Date today = new Date();
		if (today.compareTo(dateDebutDisponibilite) < 0
				&& today.compareTo(dateFinDisponibilite) > 0) {
			this.diponibilite = false;
		} else {
			this.diponibilite = true;
		}
	}

	public Chambre() {

	}

	public TypeChambre getTypeChambre() {
		return typeChambre;
	}

	public void setTypeChambre(TypeChambre typeChambre) {
		this.typeChambre = typeChambre;
	}
	


	public Date getDateDebutDisponibilite() {
		return dateDebutDisponibilite;
	}

	public void setDateDebutDisponibilite(Date dateDebutDisponibilite) {
		this.dateDebutDisponibilite = dateDebutDisponibilite;
	}

	public Date getDateFinDisponibilite() {
		return dateFinDisponibilite;
	}

	public void setDateFinDisponibilite(Date dateFinDisponibilite) {
		this.dateFinDisponibilite = dateFinDisponibilite;
	}

	public Boolean getDiponibilite() {
		return diponibilite;
	}

	public void setDiponibilite(Boolean diponibilite) {
		this.diponibilite = diponibilite;
	}



}
