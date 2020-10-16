package ClientSide;
import java.rmi.Naming;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.util.Scanner;


public class Client implements IVeterinairee{

	public static void main(String[] args) {
		

		try{
			
			
			Registry registry = LocateRegistry.getRegistry(1097);
			
			//*****************************************premiere version**************************//
			
			//IAnimal stub = (IAnimal) Naming.lookup("rmi://localhost:1097/animal");
			//IDossierSuivi stub1 = (IDossierSuivi) Naming.lookup("rmi://localhost:1097/d") ;
			/*String d= stub1.RecupererDossierSuivi() ;
			System.out.println(d);
			String DossierSuiviNv = "le poids est 41 et le nom de son maitre est NIHAD ZIOUANE " ;
		    String dNv= stub1.modifierDossierSuivi(DossierSuiviNv);
		    System.out.println(dNv);*/
			
			/*String nom_complet = stub.afficher_nomAnimal() ;
			System.out.println(nom_complet);
			System.out.println("consulter l'espece : " +stub.consulterEspece()) ;*/
			
					
			
		ICabinet stub2 = (ICabinet)registry.lookup("rmi://localhost:1097/cabinet");

	//*************************************deuxième question********************************//
		/*	Scanner sc = new Scanner (System.in);
			System.out.print("veuillez entrer le nom de votre animal: ");
			String nom = sc.next();
		if(	(IAnimal)stub2.rechercheAnimal(nom ) != null){
			System.out.println("animal trouvé dans le cabinet ") ;
		}else{
			System.out.println("animal non trouvé ! :( ") ;
		} */
			
	
		//*******************************troisième question ***********************************//
	    	//ICI je crée de nouveau patients et je les ajoute à une liste de type CabinetVeterinaire puis je fais la recherche par nom
			//le animaux que je vais ajouter ont un nom de : "chaton" "lapino" "jimmy"
			
			System.out.println("Creation de nouveau patients et les ajouter au Cabinet Veto ........ ") ;
			IAnimal a1 = stub2.createAnimal(1445, "chaton", "nihad", "Chat", new Espece("CHAT"));
			IAnimal a2 = stub2.createAnimal(1447, "lapino", "nihad", "Lapin", new Espece("LAPIN"));
			IAnimal a3 = stub2.createAnimal(1448, "jimmy", "nihad", "Chien", new Espece("CHIEN")) ;
			if(stub2.ajouterAnimal(a1 ) == true &&
					stub2.ajouterAnimal(a2 ) == true &&
			(stub2.ajouterAnimal(a3) == true)){
				
				System.out.println(" Creation et Ajout bien effectué ........ ") ;

			}else{
				System.out.println(" Creation et Ajout non effectué ........  :( ") ;

			}
			
			
			System.out.println(" Recherche d'un patient par nom  ........ ") ;

			Scanner sc = new Scanner (System.in);
			System.out.print("veuillez entrer le nom de votre animal: ");
			String nom = sc.next();
		if(	(IAnimal)stub2.rechercheAnimal(nom ) != null){
			
			System.out.println("animal trouvé dans le cabinet ") ;
		}else{
			System.out.println("animal non trouvé ! :( ") ;
		}


	
	}catch (Exception e){
		System.out.println("Client_Exception "+e.toString()) ;
		e.printStackTrace();
	}

	}
//***************************** cinquième question ********************************//

	@Override
	public void Alert(String alert) throws RemoteException {
		 System.out.println(alert);
		
	}
}