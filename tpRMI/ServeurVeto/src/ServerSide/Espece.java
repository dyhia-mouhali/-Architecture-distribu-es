package ServerSide;
import java.io.Serializable;
public class Espece implements Serializable  {

	
	private String nom_espece  ;
	
	public Espece (String nom_espece){
		this.nom_espece=nom_espece ;
	}
	
	
	public String getEspece(){
		return nom_espece ;
	}
	
	public void setEspece(String nom){
		this.nom_espece = nom ;
	}
}
