# Lern-Periode 3

Robin Müller

9.1.2024 bis 30.1.2024 (☃️ Sportferien)

## Grob-Planung

1. Ich bin mit meinen Noten zufrieden. Am stärksten war ich im Modul 319 (6) und im Modul 431 (6) und am schlechtesten in Modul 162 (5). Am besten wäre es zu programmieren!
2. Ich habe mir im letzten Modul vorgenommen meine APs genauer schreibe und schaue, dass sie 45min dauern. Diesen kann ich umsetzen indem ich mir genug Zeit nehme beim Schreiben der APs.
3. Ich programmiere ein Schere, Stein, Papier Spiel.

## 09.1.2024

✍️ Heute habe ich mir zuerst überlegt welche Projekte ich umsetzen könnte. Ich hatte als erstes die Idee eines Vokabeltrainers. Allerdings habe ich mich dagegen entschieden, da ich Lust hatte ein Spiel zu Programmiern. Da ich keine Ideen hatte habe ich ChatGPT gefragt. Dieses hat mir 20 Ideen ausgegeben. Ich habe mich nun für Schere, Stein, Papier entschieden. Danach habe ich einen PAP gemacht und die Idee mit Herrn Colic besprochen. (70 Wörter)

## 16.1.2024

- [x] Der Benutzer kann über 3 Buttons (Schere, Stein, Papier) eine Eingabe machen.
- [x] Das Programm generiert für den Gegner eine zufällige Zahl zwischen 1 - 3 (1 = Schere, 2 = Stein, 3 = Papier).
- [x] Das Programm kontrolliert wer gewonnen hat (mehrere Fälle können zusammengenommen werden).
- [x] Ich informiere mich darüber wie es funktioniert ein neues WinForms Fenster während ein anderes Fenster läuft zu starten und zu beenden. Dabei programmiere ich es in das Projekt ein.

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 1   | Programm gestartet, im ersten Form auf `Start` drücken | Benutzer drückt `Stein` | `Du hast Stein gewählt` | ja  |
| 2   | Testfall 1 | Gegner wählt `Schere` | `Der Gegner hat Schere gewählt` | ja  |
| 3   | Programm gestartet, im ersten Form auf `Start` drücken | Benutzer: Stein Gegner: Schere | `Du hast gewonnen` | ja  |
| 4   | Programm gestartet | `Start` drücken | neues Fenster öffnet sich | ja  |
| 5   | Testfall 4 > Testfall 3 | Im neuen Fenster `Beenden` drücken | neues Fenster schliesst sich | ja  |

✍️ Heute am 16.1 habe ich mit meinem Schere Stein papier Projekt gestartet. Am Anfang habe ich eine WinForms-Applikation erstellt und drei Buttons programmiert: `Schere`, `Stein`, `Papier`. Danach habe ich einen Zufallsgenerator erstellt, welcher eine Zahl für den Gegner ausgibt (1 für Schere, 2 für Stein und 3 für Papier). Anschliessdend habe ich das Vergleichen der Antworten und die Gewinnermittlung gecodet. Damit das Spiel vernünftig verwendet werden kann habe ich mich über zusätzliche Forms schlau gemacht und ein zusätzliches Form erstellt, auf welchem sich zwei Buttons befinden: `Start` und `Beenden`. Mit dem `Start`-Button wird das Forms, welches ich als erstes erstellt habe, gestartet. Mit dem `Beenden`-Button wird das Programm beendet. (109 Wörter)

☝️ Vergessen Sie nicht, bis zum 16.1 einen ersten Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt

## 23.1.2024

- [ ] Der Benutzer wird nach dem Namen gefragt und kann danach starten.
- [ ] Unter dem Eingabefeld des Benutzers gibt es eine Bestenliste. Der Gewinner erhält nun auch einen Punkt.
- [ ] Der Gewinner erhält einen Punkt und diese werden in einer Datei gespeichert (Beachte: Name 1. Stelle, Punkte 2. Stelle)
- [ ] Das Programm und alle Fenster werden per `Beenden`-Button beendet.

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 6   | Programm gestartet | `Robin` | `Hallo Robin`, 1. Runde startet |     |
| 7   | Testfall 5, eine Runde wurde gespielt | -   | `Robin ----- 1` |     |
| 8   | 1. Runde gespielt | -   | Datei in %appdata% wurde erstellt |     |
| 9   | Programm gestartet | `Beenden` drücken | alles schliesst, Datei bleibt bestehen |     |

✍️ Heute am 23.1 habe ich... (50-100 Wörter)

☝️ Vergessen Sie nicht, bis zum 23.1 Ihren fixfertigen Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt

## 30.1.2024

✍️ Heute am 23.1 habe ich... (50-100 Wörter)

## Reflexion

Formen Sie Ihre Zusammenfassungen in Hinblick auf Ihren VBV zu einem zusammenhängenden Text von 100 bis 200 Wörtern (wieder mit Angabe in Klammern).

Verfassen Sie zusätzlich einen kurzen Abschnitt, in welchem Sie über die Länge der Projekte reflektieren: Fanden Sie die 9-wöchtige LP2 oder die 4-wöchige LP3 angenehmer? Was bedeutet das für Ihre Planung der zukünftigen LP?
