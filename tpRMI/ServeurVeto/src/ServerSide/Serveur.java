package ServerSide;
import java.rmi.Naming;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;


public class Serveur {

	public static void main(String [] args) throws RemoteException{
		
		try{
			

		    
       
			
			Espece e = new Espece ("CHAT") ;
			Espece e1 = new Espece ("CHIEN") ;
			Espece e2 = new Espece ("LAPIN") ;
    
//***********************Premiere Version********************************************//
			
	//Animal animal = new Animal (123655 ,"Chaton" , "nihad" , "chaton" , e ) ;
		
	//DossierSuivi d = new DossierSuivi("le poid est 20 et son nom est : Chaton ...") ;
		
	//******************************deuxième question*********************************//
	    CabinetVeterinaire c = new CabinetVeterinaire() ;
      //  c.ajouterAnimal(animal);
       // c.ajouterAnimal(animall);
       // c.ajouterAnimal(animalll);
        
        
		Registry registry = LocateRegistry.createRegistry(1097);
	    if(registry == null ){
	    	System.out.println("Rmi registry not found .......") ;
	    }else{
	  
	    	//*****************************premier version*****************************************//
	    	//exporter l'objet distant de type DossierSuivi
	    	//Naming.rebind("rmi://localhost:1097/d", d);
	    	
	    	//exporter l'objet distant de type Animal
	    	//Naming.rebind("rmi://localhost:1097/animal", animal);
	    	
	    	
	    	//******************************deuxième et troisième question*********************************//

	    	//exporter l'objet distant de type CabinetVeterinaire
	    	registry.rebind("rmi://localhost:1097/cabinet", c);
	    	System.out.println("Server Ready !  .......") ;
	    	
	    	//*********************************Code Base ***********************************///
	    	
	    	//String url  = "file:/C:/Users/Asus-Pc/Desktop/eclipse/workspace/ClientVeto/bin/ClientSide/" ;
	          // System.setProperty("java.rmi.server.codebase" ,url);
				
	    	
	    }
		
		
		}catch (Exception e){
			System.out.println("Serveur_Exception "+e.toString()) ;
			e.printStackTrace();
		}
		
		}
		
		
}
