# Cyberscraper-Leaderboard
Du spelar som Javad, en skicklig hacker som navigerar genom tankekrävande pussel och mystiska utmaningar för att aktivera hissar och ta sig till nästa våning. Genom att hacka datasystem övervinner du hinder och erövrar nya rekord i highscore. Detta innovativa spel föddes ur en game jam med temat cyber-säkerhet, vilket återspeglas i dess spännande och futuristiska miljö. Projektet inkluderar flera scripts som hanterar mottagning, sortering och visning av highscores för alla spelare.

Teknologier
Projektet är skapat med:

Python version: 3.13 🐍
Flask version: 3.02 🔥
Unity för spelutveckling 🎮
Installation och Setup
För att köra detta projekt, installera det lokalt genom att följa dessa steg:

Klona detta repo till din lokala maskin med:
bash
Kopiera kod
git clone https://github.com/AlexPettersson/PuzzleGame.git
Installera alla nödvändiga paket med:
bash
Kopiera kod
pip install -r requirements.txt
Starta servern med:
bash
Kopiera kod
python app.py
Funktioner
Listan över funktioner som ingår i projektet:

Skicka highscore från spelet till servern. 🚀
Ta emot highscore från alla spelare och spara dem. 📥
Sortera highscores baserat på poäng. 🔢
Visa en lista med highscores på en webbsida. 📄
Flask/Python Script
Flask-appen hanterar mottagning och visning av highscores.

python
Kopiera kod
from flask import Flask, request, render_template
import os

app = Flask(__name__)

file_path = "received_data.txt"
if not os.path.exists(file_path):
    open(file_path, 'a').close()  # Skapa filen om den inte finns
os.chmod(file_path, 0o777)  # Ställ in filbehörigheter för att tillåta läs- och skrivåtkomst för alla användare

def save_data_to_file(data):
    try:
        with open(file_path, "a") as f:
            f.write(data)
    except Exception as e:
        print("Error saving data to file:", e)

def read_data_from_file():
    try:
        with open(file_path, "r") as f:
            lines = f.readlines()
            # Sortera rader baserat på det numeriska värdet i början av varje rad
            sorted_content = sorted(lines, key=lambda x: float(x.split()[0]), reverse=True)
            return sorted_content
    except Exception as e:
        print("Error reading data from file:", e)
        return None

@app.route('/', methods=['GET', 'POST'])
def receive_data():
    if request.method == 'POST':
        data = request.form.get('data')
        save_data_to_file(data)

    sorted_content = read_data_from_file()
    if sorted_content:
        return render_template('index.html', sorted_content=sorted_content)
    else:
        return "Error reading data from file"

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=8080)
Unity C# Script
Unity-skriptet skickar highscore till servern när spelaren har klarat en nivå.

csharp
Kopiera kod
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Send : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Send_Score()
    {
        StartCoroutine(SendPostRequest());
    }

    private IEnumerator SendPostRequest()
    {
        string post = "\n" + LevelLoader.Score + " | " + Read_Input.name_input + " ";
        WWWForm form = new WWWForm();
        form.AddField("data", post);
        
        using (UnityWebRequest www = UnityWebRequest.Post("https://63abc309-e44c-4e38-8f5f-fedb06a8db09-00-hhzd08itb3te.worf.replit.dev/", form)) // Uppdatera URL med din Replit app URL
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError(www.error);
            }
            else
            {
                Debug.Log("Post request sent successfully");
            }
        }
    }
}
Med dessa scripts kan spelare skicka sina highscores till servern, där de sorteras och visas på en webbsida, vilket ger en översikt över alla spelares prestationer.
Text som består av olika förekomande variabler som gör att flera delar av koden ändras om man ändrar en sak för att underlätta. 💻
Kontakt
Skapad av Alex Pettersson & Martin Rockström - gärna kontakta oss! alex.pettersson@elev.ga.ntig.se eller martin.rockstrom@elev.ga.ntig.se 📞
