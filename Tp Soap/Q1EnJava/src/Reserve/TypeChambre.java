package Reserve;

public class TypeChambre {

	private int nbrLits, prixBase;

	public TypeChambre(int prixBase, int nbrLits) {

		this.prixBase = prixBase;
		this.nbrLits = nbrLits;
	}

	public int getPrixBase() {
		return prixBase;
	}

	public void setPrixBase(int prixBase) {
		this.prixBase = prixBase;
	}

	public int getNbrLits() {
		return nbrLits;
	}

	public void setNbrLits(int nbrLits) {
		this.nbrLits = nbrLits;
	}

}
