﻿Quotes Language: german


# Fallstricke

Die ausführbare Spezifikation verlässt sich darauf, dass der NerdGolfTracker seine Ausgabe auf einmal tätigt, technisch gesprochen: dass der Output-Stream nur einmal geflusht wird. Würde mehrmals geflusht werden, wäre das Lesen der Ausgabe im `TrackerDriver` unzuverlässig.


# Absichtliche Fehler

* Bei der Ausgabe der aktuellen Schläge wird "Schlag" nur im Singular ausgegeben.
* Beim Lochwechsel wird die Zahl der Schläge nicht zurückgesetzt.
* Bei der Ausgabe des aktuellen Lochs fehlt ein Leerzeichen zwischen Zahl and "Loch".
* Bei der Hilfe-Ausgabe ist die Einleitung nicht durch einen Zeilenumbruch abgetrennt.


