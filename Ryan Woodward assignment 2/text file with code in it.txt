/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package swc.bank.system;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.Random;



public class SWCBankSystem {

     //Max amount of arrays so more can be added  
      static ArrayList<String> memPass = new ArrayList();
      static ArrayList<String> normPass = new ArrayList();
      static ArrayList<String> userName = new ArrayList();

       static Scanner in = new Scanner(System.in);
      
      //scanners
     
public static void main(String[] args) {
    
    // array lists    
      // memory passwords    
         memPass.add("bingbingbong");
         memPass.add("chicken123");
         memPass.add("youhavenpowerhere");  
         memPass.add("youwereweak");
         memPass.add("nonono");

              // normal passwords   
        normPass.add("Makeamericagr8");
        normPass.add("Infinityifif1");
        normPass.add("Flyufools1");
        normPass.add("Darkside2");
        normPass.add("Unlimitedpower1");

              //usernames    
        userName.add("donaldtrump"); // 0
        userName.add("barrackobama"); // 1
        userName.add("gandalfthegray"); // 2
        userName.add("darthvader"); // 3
        userName.add("emperorpalp"); // 4


       




      
       Random r = new Random();

       //nameing strings 
 
            String loginUser="";
            String userPasswordSaved="";
            String userMemData="";
 
             boolean userFound =false;

 
            System.out.println("Hello, Welcome to South West College Bank");
            do
            {
                    //log in / sign up stage : going log in first 
                    System.out.println("\nPlease choose from the option below:\nL. Login \nA. New account \nE. Exit");


                    loginUser = in.nextLine();
                // determines if the presses L or l 
                        if(loginUser.equalsIgnoreCase("L"))
                        { 
                             userFound=false;
                            // entering user name   
                            System.out.println("enter please enter your username:");

                            //input for user name here
                            String userUsername  = in.nextLine();

                            System.out.println("Please enter password:");
                            String userPassword =in.nextLine();   
                            
                            int random1 =r.nextInt(7);
                            System.out.println("please enter character" + random1 + "from your memorable data");
                            char mem1 = in.nextLine().charAt(0);

                            int random2 = r.nextInt(7);
                            System.out.println("Please enter charcter" + random2 +"from your memorable data");
                            char mem2 = in.nextLine().charAt(0);

                            int random3 = r.nextInt(7);
                            System.out.println("Please enter charcter" + random3 +"from your memorable data");
                            char mem3 = in.nextLine().charAt(0);

                            
                            //if username isnt found then user name is false
                            boolean userFoundName =false;
                            int userNum = 0;


                            // if username is found from the array list then array list gets username   
                           for(int i = 0; i< userName.size(); i++)
                              {

                                  if (userName.get(i).equals(userUsername))
                                  {
                                   userFoundName = true;
                                   userNum = i;

                                  }
                              }//end for    


                    
                   //if user gets password from array list then it is correct
                     //if user exists and password matches and mem data matches, then successful log in
                       if (userFoundName == true &&
                           normPass.get(userNum).equals(userPassword) &&
                           memPass.get(userNum).charAt(random1) == mem1 &&
                           memPass.get(userNum).charAt(random2) == mem2 &&
                           memPass.get(userNum).charAt(random3) == mem3
                          
                           )    
                             
                       {
                            System.out.println("Invailid login");//logged in
                           
                       }
                       else{
                           System.out.println("user logged in");//not logged in
                       }
                       
                }else if(loginUser.equalsIgnoreCase("A"))
                {  
                            accountCreation(userName, normPass, memPass);//call method
                }else if(loginUser.equalsIgnoreCase("E"))
                { 
                }
                                     
        }while(!loginUser.equalsIgnoreCase("E"));
       

        
        
        
        
        
        

}//end main

public static void accountCreation(ArrayList<String> userNameArray, ArrayList<String> userPassArray, ArrayList<String> userMemArray){
    //add new account process
    
    
    //ask user to enter their name
    
    
    //check length of name - if it is invalid (less than 6 or greater than 12), then need to show error and get user to try again
    
    //check name is unique - if it is already in the array, then need to show error and get user to try again
    
    boolean invalid=false;//a boolean variable that we can set if invalid input is entered
//username
        do//start do loop to allow the user to try again if input is invalid
        {
            invalid = false; //set invalid to false
            //ask the user to enter one or more words
            System.out.println("Please enter a username ");
            //read in the user input and store in the variable userWord
            String user_name = in.nextLine();

            //if lnght is less than 6 or greater then 12
            if (user_name.length() < 6&&  || user_name.length() >12)
            {
                //output error message and ask user to try again
                System.out.println("username is either to short or too long ");
                
                //set boolean to true
               invalid=true;
               
            }
            else{

                // if username is found from the array list then it is invalid   
               for(int i = 0; i< userNameArray.size(); i++)
                  {

                      if (userNameArray.get(i).equals(user_name))
                      {
                            //output error
                          System.out.println("username already taken please try again");
                            //set boolean to true
                          invalid=true;
                      }
                  }//end for    
            }
           

        } while (invalid == true);//repeat the code while the user has entered invalid input

       
    
    
    
    
    //ask user to enter their password
    //password
          do{
              invalid = false;
              System.out.println("Please enter a password \nPasword must best 8 charcters long");
              String userPass = in.nextLine();

            //if lnght is less than 6 or greater then 12
            if (userPass.length() != 8)
            {
                //output error message and ask user to try again
                System.out.println("password is not 8 chartacters long ");
                
                invalid=true;
                
                }
            
            
            
                  if (!Character.isLetter(userPass.charAt(0)))
            {
             
                System.out.println("Password should begin with a letter ");
               
                invalid=true;
               
                }
            else{

                // if username is found from the array list then it is invalid   
               for(int i = 0; i< userPassArray.size(); i++)
                  {

                      if (userPassArray.get(i).equals(normPass))
                      {
                            //output error
                          System.out.println("invalid password");
                            //set boolean to true
                          invalid=true;
                      }
                  }//end for    
            }
                   for (int i = 0; i < userPass.length(); i++)
            {
                
                if (!Character.isLetter(userPass.charAt(i)) && !Character.isDigit(userPass.charAt(i)))
                {
                                            
                             System.out.println("Password contains invalid characters, numbers and letters only ");
               
                             invalid=true;
                    break; 
                    
          }while (invalid==true);
          
           
          //meroable data 
    do{
              invalid = false;
              System.out.println("Please enter a memorable data ");
              String userPass = in.nextLine();

            //if lnght is less than 6 or greater then 12
            if (userMem.length() != 8)
            {
                //output error message and ask user to try again
                System.out.println("memorable data must be 8 charcters long ");
                
                invalid=true;
                
                }
            else{

                // if username is found from the array list then it is invalid   
               for(int i = 0; i< userMemArray.size(); i++)
                  {

                      if (userMemArray.get(i).equals(memPass))
                      {
                            //output error
                          System.out.println("memorable data invalid");
                            //set boolean to true
                          invalid=true;
                      }
                  }
               
               for (int i = 0; i < userMem.length(); i++)
            {
                
                if (!Character.isLetter(userMem.charAt(i)) && !Character.isDigit(userMem.charAt(i)))
                {
                                            
                             System.out.println("Password contains invalid characters, numbers and letters only ");
               
                             invalid=true;
                    break; 
                    
            }
    }while (invalid==true);
    
  
    storage = true;
    
    int userCount = 4;
    
    for(userNameArray[userCount] = username; )
    {
        if(storage = true){
            System.out.println("username stored");   
        }
    }
    
    for(userNameArray[userCount] = userPass; )
    {
        if(storage = true){
            System.out.println("password stored");   
        }
    }
    
    for(userNameArray[userCount] = userMem; )
    {
        if(storage = true){
            System.out.println("memorable data stored stored");   
        }
    }
    //add data to array
    
}


}//end class
