package Reserve;

import java.util.ArrayList;
import java.util.Date;
import Reserve.Chambre;

import Reserve.Adresse;

public class RechercheHotel {
	
	private ArrayList<Hotel> list = null;

	public RechercheHotel() {
		
		this.list = new ArrayList();
	}
	public Boolean add(Hotel hotel){
		
		if(!list.contains(hotel)){
			list.add(hotel);
			return true;
		}else {
			return false;
		}
	}
	public ArrayList rechercherHotel(String villeSejour , Date datedepart , Date dateArrivee , Double prixMin , Double prixMax , int nombreEtoile , int nombrePersonne)
    {
        ArrayList hotels = new ArrayList();
        for(Hotel  h:  list)
        {

        	if (h.getAdresse().getVille().equals(villeSejour) && h.nombreEtoile==nombreEtoile){
        		for (Chambre ch : h.chambres) {
        		
        			if (dateArrivee.compareTo(ch.getDateDebutDisponibilite()) < 0 && datedepart.compareTo(ch.getDateFinDisponibilite()) > 0 && ch.getTypeChambre().getPrixBase() <= prixMax && ch.getTypeChambre().getPrixBase() >= prixMin && ch.getTypeChambre().getNbrLits() == nombrePersonne) {
        			hotels.add(h);
        			}
				}
        		
        	}
        }
        return hotels ;
    }


    public ArrayList getHotels()
    {
        return list;
    }

}
