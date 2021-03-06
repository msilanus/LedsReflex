/**********************************************************
*
* Jeu de reflexes
*
* Auteurs : MAISTRE BAZIN Mathis et TOURRES Hugo
* Date   : 16/12/2016
*
* Matériel : BreadBoard, 6 LEDs, 4 boutons poussoirs.
*
* Fonctionnement : presser le bouton face à la led allumée.
*
**********************************************************/

// Durée relatives aux niveaux de jeu
#define DUREE1 1000;
#define DUREE2 600;
#define DUREE3 350;
#define DUREE4 200;

// Définitions des variables
int led[4] = {13, 12, 11, 10};  // LEDs du jeu
int led5 = 9;  //LED verte  : Réussite
int led6 = 8;  // LED rouge : Echec
int btn[4] = {7, 6, 5, 4};
int btnState[4] = {0, 0, 0, 0};
int comptLed;
int comptBtn = 0;
int score = 0;
bool jeu = false;
int randNumber;
int duree = DUREE1;

void setup()
{
  Serial.begin(250000);

  /*
   randomSeed() initializes the pseudo-random number generator, causing it to start at an arbitrary point in its random sequence. 
   This sequence, while very long, and random, is always the same. 
   If it is important for a sequence of values generated by random() to differ, on subsequent executions of a sketch, 
   use randomSeed() to initialize the random number generator with a fairly random input, such as analogRead() on an unconnected pin.  
   */
  randomSeed(analogRead(0));
  for (int i = 0; i < 4; i++) pinMode (led[i], OUTPUT);
  pinMode (led5, OUTPUT);
  pinMode (led6, OUTPUT);
  for (int i = 0; i < 4; i++) pinMode (btn[i], INPUT);
}

void loop()
{
  //Attente du départ 
  if (Serial.available() > 0)
  {
    char recu = Serial.read();
    switch (recu)
    {
      case 'F' : duree = DUREE1; jeu = true; break;  // Facile
      case 'M' : duree = DUREE2; jeu = true;break;   // Moyen
      case 'H' : duree = DUREE3; jeu = true;break;   // Hardcore
      case 'E' : duree = DUREE4; jeu = true; break;  // Top ladder
    }
    // Si jeu pas terminé
    if (jeu)
    {
      // 20 tentative
      for (int k = 0; k < 20; k++)
      {
        // Nombre aléatoire entre 0 et 3
        randNumber = random(4);
        // Allumer une led aléatoirement
        digitalWrite(led[randNumber], HIGH);
        // Calcul de la position de la led allumée
        // Rq : pow renvoit 99 pour randNumber=2 et 999 pour randNumber=3
        comptLed = pow(10, randNumber);
        if (randNumber > 1) comptLed = comptLed + 1;

        delay(duree);

        //////////////////////////////////////////////////////////////////// Pour j=0 jusqu'a duree
        for (int j = 0; j < duree; j++)
        {
          //////////////////////////////////////////////////////////////////   Lire les boutons
          for (int i = 0; i < 4; i++)
          {
            btnState[i] = digitalRead(btn[i]);
          }
          comptBtn = btnState[0] + btnState[1] * 10 + btnState[2] * 100 + btnState[3] * 1000;
          // DEBUG :
          //    Serial.print("BTN : ");
          //    Serial.println(comptBtn);
          
          //   Si bon bouton score = score +1
          if (comptBtn == comptLed)
          {
            digitalWrite(led5, HIGH);
            delay(250);
            score++;
            j = 1000;
          }
        } // passer au i sivant
        // Eteindre LED réussite
        digitalWrite(led5, LOW);
        
        // Echec
        if (comptBtn != comptLed)
        {
          digitalWrite(led6, HIGH);
        }
        
        // Eteindre les LEDs
        for (int i = 0; i < 4; i++) digitalWrite(led[i], LOW);
        delay(250);
        digitalWrite(led6, LOW);

        // Transmettre sur le port série
        // DEBUG :
        //Serial.print("Score : ");
        
        Serial.println(score);
        
        // DEBUG :
        //Serial.print(" / ");
        //Serial.println(k + 1);

      }
      // Partie terminée
      Serial.println("Q");
      jeu=false;
    }
  }

}
