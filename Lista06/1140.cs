using System;

class Program {
  public static void Main () {
    
    string s = Console.ReadLine(); 
    
    while (s != "*") {

        s = s.ToLower(); // passa para minúsculo
      
        char x = s[0];   // primeira letra
      
        bool bugou = false; // bugou é verdadeiro qnd encontra letra diferente
      
        for (int i = 0; i<s.Length; i++) 
      
          if (s[i]==' ' && s[i+1] != x) // letra apos espaco eh diferente
      
      {
        bugou = true;
        break;
      }
        if(bugou == true) Console.WriteLine("N");
      
      else Console.WriteLine("Y");
      
        s = Console.ReadLine(); 
  
    }  
  }
}