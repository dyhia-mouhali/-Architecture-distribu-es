package Reserve;

import java.util.ArrayList;

public class Reservation {
	public ArrayList reservations = null;

	public Reservation() {
	
		this.reservations = new ArrayList();
	}
	public Boolean reserver(Client c){
		if(!reservations.contains(c)){
			reservations.add(c);
			return true;
		}else{
			return false;
		}
	}
	

}
