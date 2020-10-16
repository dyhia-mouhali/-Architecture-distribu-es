package ServerSide;
import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.util.ArrayList;




public class CabinetVeterinaire extends UnicastRemoteObject implements ICabinet {

	
	private static final long serialVersionUID = 1L;
	ArrayList <IAnimal> patients =  new ArrayList <IAnimal> () ;
	protected CabinetVeterinaire() throws RemoteException {
		super();
	
		}
	
	
	
	@Override
	public IAnimal rechercheAnimal(String nom) {
		IAnimal a = null ;
		for(int i=0 ; i<patients.size() ; i++){
			try {
				if (patients.get(i).getNom().equals(nom)){
					a= patients.get(i);
				}
			} catch (RemoteException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
		
		return a ;
	}
	
	@Override
	public Boolean ajouterAnimal(IAnimal a) {
		if(patients.add( a) == true){
			return true ;
		}else
			return false ;
	}


	@Override
	public IAnimal createAnimal(int AnimalID ,String nom , String nom_maitre , String race , Espece espece) throws RemoteException {
		
		return new Animal (AnimalID , nom , nom_maitre , race , espece);
	}



	

	

}
