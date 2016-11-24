/*
  Autore: Andrea Micheli  Classe: 5-AA 
  Descrizione: Programma per comadnare da seriale un motore con ponte a H
*/

//Definisco componenti per programma

#define MAX 100 
#define MIN 0
#define up 51
#define down 53

//Dichiaro varibili

char c[MAX]; //Array di caratteri --> ci savlo ciò che arriva dalla seriale
int i = 0; //Indice --> serve per poter scorrere l'array

//Funzione di default di Arduino, viene eseguita solo il primo ciclo

void setup() {
  Serial.begin(9600); //Inizializzo la seriale con Baude-Rate a 9600
  pinMode(up,OUTPUT); //Definisco il pin up (13) come output
  pinMode(down,OUTPUT); //Definisco il pin down (14) come output
}

//Funzione di default di Arduino, viene eseguita sempre dopo il setup

void loop() {

  //Verifico se la porta seriale è disponibile e se sta ricevendo dati (>0)
  
  if(Serial.available() > 0) { 

    //Se la porta fosse disponibile devo salvare nella variabile #c tutto ciò che mi arriva
    //Uso il carattere #$ come indicatore di fine riga --> ricordarsi di inserirlo in Visual Studio a fine della stringa
    //In questa maniera il ciclo sarà vero fino a quando non ricevo tale carattere, ed appena lo ricevo finisco di salvare ciò che mi arriva nelle varie caselle dell'array
    //L'array sarà swithcatto di un indice per ogni carattere ricevuto, quidni per ogni ciclo del while
    
    do {
     c[i] = Serial.read();
     i++;
    } while(c[i] != '$');
    
    i = 0; //resetto indice array

    //Controllo principale del programma, se vale 1 allora accendo un pin vieversa l'altro
    //In questo modo riesco a comandare il ponte a H
    
    if(c[0] == '1') {
      Serial.write("up");
      digitalWrite(up, HIGH);
      digitalWrite(down, LOW);
    }
    if(c[0] == '0') {
      Serial.write("down");
      digitalWrite(up, LOW);
      digitalWrite(down, HIGH);
    }
    if(c[0] == '2') {
      Serial.write("Spengo");
      digitalWrite(up,LOW);
      digitalWrite(down,LOW);
    }
  }
}
