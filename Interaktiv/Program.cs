        string val1;
        string val2;
        
        Console.WriteLine("Du vaknar i en mörk skog och du har 2 alternativ höger eller vänster.");
        Console.WriteLine("Väljer du att gå till vänster (skriv 'vänster') eller höger (skriv 'höger')?");
        Console.WriteLine("Ditt val: ");

        
        val1 = Console.ReadLine();  


        if (val1.ToLower() == "vänster")
        {
            Console.WriteLine("Du går på den vänstra stigen och kommer fram till en flod.");
            Console.WriteLine("Vill du simma över floden (skriv 'simma') eller följa floden (skriv 'följa')?");
            Console.WriteLine("Ditt val: ");
       
       
        
        val2 = Console.ReadLine();  

            if (val2.ToLower() == "simma")
            {
                Console.WriteLine("Du försöker simma över floden, men strömmen är för stark. Du sveps iväg och kan inte ta dig tillbaka.");
                Console.WriteLine("Slut: Du druknade medans du simmade i strömmen.");
            }
            else if (val2.ToLower() == "följa")
            {
                Console.WriteLine("Du följer floden och hittar en gammal bro som du säkert kan korsa.");
                Console.WriteLine("Slut: Du hittade en väg ut ur skogen.");
            }
        }
        else if (val1.ToLower() == "höger")
        {
            Console.WriteLine("Du tar den högra stigen och hamnar framför en stor grotta.");
            Console.WriteLine("Vill du gå in i grottan (skriv 'gå in') eller gå runt grottan (skriv 'gå runt')?");
            
        val2 = Console.ReadLine(); 

            if (val2.ToLower() == "gå in")
            {
                Console.WriteLine("Du går in i grottan och upptäcker en skattkista fylld med guld.");
                Console.WriteLine("Slut: Du blev rik och lever lyckligt i alla dina dagar.");
            }
            else if (val2.ToLower() == "gå runt")
            {
                Console.WriteLine("Du går runt grottan och stöter på ett aggressivt vilddjur.");
                Console.WriteLine("Slut: Du blev attackerad och kunde inte fly.");
            }
        }
        
Console.ReadLine();