TAMMMobile
### Cross-platform Mobile Application for smart metering

# Release Notes

<!------------------TEMPLATE-----------------
### X.X.X.0 (YYYY-MM-DD)
##### Dependencies: CrossPlatform X.X.X.0, TSM X.X.X.0, TAMM Shared Libraries X.X.X.0, MDM X.X.X.0 
- [Added|Changed|Removed|Fixed] Description
------------------------------------------->
### X.X.X.0 (YYYY-MM-DD)
##### Dependencies: CrossPlatform 4.1.0.0, TSM 2.4.5-b1, TAMM Shared Libraries 4.2.2.0, MDM 3.5.7.2


### 5.0.0.2 (2025-09-15) (MAUI)
##### Dependencies: CrossPlatform 4.1.0.0, TSM 2.4.4-b11, TAMM Shared Libraries 4.2.2.0, MDM 3.5.7.2
[Added] Integrazione Digicom Gateway (71471)
[Added] Integrazione CTR V8 Fiorentini FAST MODUS
[Added] Integrazione CTR V8 D&D IMP-FC
[Added] Integrazione CTR V8 CPL F4
[Added] Integrazione Metersit C&I NBIoT (79551)
[Changed] Cartella applicazione: spostamento da scheda di memoria esterna a Android/data/com.terranovasoftware.tammmobile
[Fixed] Logout forzato se credenziali cambiate con rinnovo silente del token (77495)
[Fixed] Explorer Mini: Scrittura IP e Porta, esito test di comunicazione

### 4.2.7.0 (2025-07-11)
##### Dependencies: CrossPlatform 4.1.0.0, TSM 2.4.4-b9, TAMM Shared Libraries 4.2.2.0, MDM 3.5.7.2
[Added] Integrazione CTR V8 Fiorentini HM
[Added] Fiorentini HM Icon NBIoT: Aggiornamento Firmware
[Fixed] Fiorentini HM Icon NBIoT: Gestione PLMN UNITS-13
[Added] Itron Corus aggiunti i downloader (Consumi giornalieri e orari, eventi metrologici e non)
[Added] Sostituzione in emergenza: elenco dei soli modelli 2G se il chiamante non fornisce il numero di serie
[Added] Selezione modello: Informativa sulla porta ottica configurata su MDM per costruttore
[Added] Invio del nome dell'operatore loggato (o dell'ultimo operatore loggato) nelle api di richiesta licenza a MDM
[Fixed] CTR: valorizzazione dell' IDTLT con il PDR letto dal dispositivo 

### 4.2.6.0 (2025-06-13)
##### Dependencies: CrossPlatform 4.1.0.0, TSM 2.4.4-b9, TAMM Shared Libraries 4.2.2.0, MDM 3.5.7.2
[Added] Profilazione comandi Test di comunicazione, Affiliazione, Apri Valvola, Chiudi Valvola, Importazione Chiavi

### 4.2.5.0 (2025-06-11)
##### Dependencies: CrossPlatform 4.1.0.0, TSM 2.4.4-b9, TAMM Shared Libraries 4.2.2.0, MDM 3.5.7.2
[Added] Selettore di Baud Rate quando il modello supporta più velocità di comunicazione
[Added] Integrazione CTR V2 Fiorentini Explorer Mini
[Added] Integrazione CTR V2 Fiorentini Explorer Plus
[Added] Integrazione CTR V2 Fiorentini Explorer Zero
[Added] Integrazione CTR V8 Elgas picoElcor
[Added] Integrazione CTR V8 MeterItalia Ecor4
[Added] Integrazione CTR V8 Cpl Concordia Ecor3
[Added] Integrazione CTR V8 Cpl Concordia EGx
[Added] Integrazione CTR V8 TecnoSystem Cubo
[Added] Integrazione CTR V8 Metrix MX 3000
[Added] Integrazione CTR V8 Metrix MX 3000S
[Added] Integrazione CTR V8 TecnoSystem Pitagora
[Added] Integrazione CTR V8 SacofGas_Ph

### 4.2.4.0 (2025-04-07)
##### Dependencies: CrossPlatform 4.1.1.0, TSM 2.4.4-b9, TAMM Shared Libraries 4.2.3.0, MDM 3.5.9.2
[Changed] Localizzazione eventi Metersit Dlms/Iec
[Fixed] Metersit NBIoT IEC: Reset Diagnostica
[Fixed] Metersit NBIoT IEC: Scrittura IP e Porta
[Fixed] Fiorentini SSM ICON 250 LTE: connessione con modelli con firmware metrologico uguale o superiore a 271 e non metrologico uguale o superiore a 256

### 4.2.3.0 (2025-03-21)
##### Dependencies: CrossPlatform 4.1.0.0, TSM 2.4.4-b9, TAMM Shared Libraries 4.2.2.0, MDM 3.5.7.2
[Changed] Samgas e Fiorentini NBIoT: Aggiornamento Firmware
[Changed] Samgas e Fiorentini GSM: Aggiornamento Firmware
[Changed] Samgas e Fiorentini 169: Aggiornamento Firmware
[Added] Integrazione Watertech NTC NBIoT (74258)
[Added] Integrazione Siconia NTC NBIoT (74257)
[Added] SSM Icon 250 LTE: gestione nuovo bit PGV (74473)
[Added] SSM Icon 250 LTE: gestione nuova causa chiusura valvola (74475)
[Added] SSM Icon 250 LTE: gestione nuovo bit in maschera Allarmi (74476)
[Added] SSM Icon 250 LTE: gestione nuovo evento metrologico (74477)
[Added] SSM Icon 250 LTE: gestione nuovo allarme (74477)
[Fixed] Fiorentini RSV NBIoT: download misure VM e VME
[Fixed] Fiorentini SSM NTC NBIoT: download misure VM e VME
[Fixed] Modelli NBIoT UNITS-12: visualizzazione dati di monitoraggio assieme all'esito dopo test di comunicazione (74585)
[Fixed] Modello Metersit 169 DLMS: Errore scrittura "Affiliazione con concentratore" (Rimozione del flag non supportato) (74698)
[Fixed] Modello Metersit NBIOT DLMS: Errore cambiuo stato del dispositivo (74673)
[Fixed] Modello Metersit NBIOT DLMS: Errore Reset Diagnostica (74672)
[Fixed] Modello Metersit NBIOT DLMS: Mancata visualizzazione campo "Cause chiusura valvola" (74668)
[Fixed] Modello Metersit 169 DLMS: Errore reset diagnostica (74701)
[Fixed] Modello Metersit NBIOT DLMS: Errore Push Scheduler (74670)
[Fixed] Modello Metersit 169 DLMS: Errore scrittura "Impostazioni avanzate" (scrittura del parametro "Stato Orfano") (74702)
[Fixed] Modello Metersit 169 DLMS: Mancata scrittura e visualizzazione "Disco" (Il campo "Disco" non risulta nè visibile, né scrivibile) (74697)
[Fixed] Modello Metersit 169 DLMS: Errore chiusura valvola (L'esecuzione della chiusura valvola non produce effetti) (74699)

### 4.2.2.0 (2025-02-24)
##### Dependencies: CrossPlatform 4.1.0.0, TSM 2.4.4-b9, TAMM Shared Libraries 4.2.2.0, MDM 3.5.7.2
[Added] AEM EUS 169: Processo di affiliazione
[Added] AEM EUS-2 169: Processo di affiliazione
[Added] Integrazione Siconia 169 MHz
[Added] Watertech WTGS NBIOT: Test di comunicazione, indicazione all'operatore su dove consultare l'esito sul display
[Added] Tutti i modelli: descrizione localizzata degli eventi scaricati dai meter
[Fixed] Watertech WTGS NBIOT: Test di comunicazione, gestione inserimento push e delay
[Fixed] Watertech WTGS NBIOT: Test di comunicazione, strategia con solo lancio del comando senza leggere risultato dal misuratore
[Fixed] Metersit: Keep Alive
[Fixed] WaterTech NBIoT: Gestione comunicazione
[Fixed] WaterTech NBIoT: APN Username e Password

### 4.2.1.0 (2025-01-28)
##### Dependencies: CrossPlatform 4.1.0.0, TSM 2.4.4-b7, TAMM Shared Libraries 4.2.1.0, MDM 3.5.7.2
[Added] Integrazione Hp Meter Italia Gsm (70868)
[Added] Integrazione Metersit GPRS DLMS (72208)
[Added] Gestione modulo commerciale "R-GMBLE	RETIAMM MOBILE – RMB – Gestione lingue: interfaccia per la lingua inglese"
[Added] Gestione dei log con eliminazione di quelli più vecchi secondo parametro di MDM (rollover)
[Changed] Ottimizzazione procedura di Logout
[Changed] Ottimizzazione uso oggetti interni in modalità Standalone/AppToApp
[Changed] Aggiornamento a TerranovaORM 1.62.25
[Changed] Watertech NBIoT: Push Scheduler secondo standard UniTS
[Fixed] Visualizzazione dell'archivio dati con scrollbar
[Fixed] Navigazione pratiche AppToApp, attività in campo (DSO), Standalone BT Enel, Configuratore Acqua, Walk-By
[Fixed] Watertech: Test di comunicazione con solo avvio (senza verifica esito) (72211)
[Fixed] Texnopark Gprs: download curve di carico orarie (71929)
[Fixed] Fiorentini Rse NBIoT: download archivio totalizzatori giornalieri (72038)
[Fixed] Fiorentini SSM NTC NBIoT: aggiunta strategia per test di tenuta valvola nel menu (71926)
[Fixed] Fiorentini SSM Icon NBIoT: aggiunti i flag mancanti per il reset degli eventi metrologici e non metrologici (71924)
[Fixed] Fiorentini SSM Icon NBIoT: corrette le letture dei totalizzatori da Vm e Vme a Vb e Ve (71923)
[Fixed] Fiorentini RSV NBIoT: aggiunta strategia per test di tenuta valvola nel menu (71446)
[Fixed] Siconia NBIoT: abilitato il Push Scheduler For Billing
[Fixed] Gestione curve GME (gestione campioni quartorari non ancora registrati dal meter) (72361)
[Fixed] Meteritalia 169 Mhz - errore chiusura valvola (71270)
[Fixed] Meteritalia 169 Mhz - Anomalia abilitazione modulo RF (71274)
[Fixed] Visualizzazione del messaggio nel caso in cui la sonda non venga rilevata (72861)

### 4.2.0.0 (2024-11-28)
##### Dependencies: CrossPlatform 4.0.0.0, TSM 2.4.4-b7, TAMM Shared Libraries 4.0.0.0, MDM 3.5.7.2
[Changed] Walk-By Drive-By: abilitata gestione moduli commerciali R-HMBW / R-HMBWO in fase di ricezione trama OMS
[Changed] Walk-By Drive-By: abilitata gestione moduli commerciali R-HMBW / R-HMBWO per sblocco navigazione
[Changed] Aggiornamento moduli commerciali di sblocco meter Gas, Elettrico, Acqua in funzionalità Stand alone
[Changed] Meteritalia GSM: rimosso parametro durata da vista test di tenuta
[Added] Implementato aggiornamento firmware per Fiorentini Hme Gsm
[Added] Implementato aggiornamento firmware per Itron Gallus Net
[Added] Processi Meter elettrici BT: inserite in esito attività le informazioni "Parola di stato estesa 2" e "Parola di stato estesa 3" acquisite da bundle SMPR (EXTENDED_STATUS_WORD_2 e EXTENDED_STATUS_WORD_3) (#71621)
[Added] Integrazione Aem Eus 169
[Added] Integrazione Aem Eus-2 169
[Added] Integrazione Aem Eus Gsm
[Added] Gestione modulo commerciale R-XMB3 RETIAMM MOBILE - RMB - Gestione avanzata profili operatori: abilitata profilazione costruttori e voci di menu in modalità Stand alone Gas/Acqua/Elettrico 
[Added] Gestione modulo commerciale R-GMB16	RETIAMM MOBILE - RMB - Acquisizione letture 269-2022
[Added] Dialog "Elaborazione dati in corso..." al termine del downlod dei dati, prima della visualizzazione della dialog di esito attività
[Added] Login silente in caso di token scaduto
[Changed] Verifica moduli commerciali e modelli profilati in sola fase di avvio attività Stand alone (bottone Connetti in dialog di selezione modello) 
[Changed] Attività Stand alone: abilitata verifica tra matricola rilevata e matricola con cui è stata avviata l'attività con conseguente blocco delle attività nel caso non coincidano
[Changed] Finestra di risveglio random visibile solo se almeno un orario di Push Scheduler è selezionato
[Fixed] Siconia NBIoT: scrittura Sostituzione Batteria, scrittura Push Scheduler, scrittura IP e Porta, lettura Cause Chiusura Valvola, esecuzione Test di Comunicazione
[Fixed] Modulo dati isola: corretta la tipologia di totalizzatori (istantanea/giornaliera) in meter GAS
[Fixed] Fiorentini RSE NBIoT: scrittura parametri in Nuova Istallazione, Gestione Comunicazione, flag PGV da verificare
[Fixed] Fiorentini RSV NBIoT: avvio test di comunicazione
[Fixed] Meteritalia GSM: scrittura PIN in gestione PGV da verificare
[Fixed] Zenner NBIoT: lancio test di comunicazione, scrittura PIN in gestione PGV 
[Fixed] Tutti i meter: label "Avvia test di comunicazione"
[Fixed] Fiorentini RSE 169Mhz: Abilitazione modulo RF

### 4.1.45.0 (2024-09-19)
##### Dependencies: CrossPlatform 2.2.1.0, TSM 2.4.4-b4, TAMM Shared Libraries 2.2.2.0, MDM 3.5.4.3
[Added] Tasto chiudi in finestre di dialogo

### 4.1.44.0 (2024-09-11)
##### Dependencies: CrossPlatform 2.2.1.0, TSM 2.4.4-b4, TAMM Shared Libraries 2.2.2.0, MDM 3.5.4.3
[Added] Watertec WT NBIoT
[Changed] Pulizie varie in modalità standalone GME e Gas
[Changed] Normalizzazione degli eventi
[Changed] Normalizzazione dati a seguito modifiche in outsourcing
[Changed] Introduzione modifiche protocollo IEC per Metersit
[Fixed] Refresh riepilogo Archivio dati a seguito di sincronizzazione su server
[Fixed] Gestione transazioni su Database locale

### 4.1.43.0 (2024-08-16)
##### Dependencies: CrossPlatform 2.2.1.0, TSM 2.4.4-b4, TAMM Shared Libraries 2.2.2.0, MDM 3.5.4.3
[Fixed] Zenner NBIoT e GSM: scrittura soglia tentativi di effrazione in Configurazione Valvola
[Added] Integrazione Fiorentini HM Icon NBIot
[Added] Modulo dati isola: salvataggio su db interno e sincronizzazione su MDM di curve, totalizzatori ed eventi di meter GME (gestione modulo R-EMB14 RETIAMM BOBILE – RMB - Acquisizione, salvataggio e upload dati del misuratore GME)

### 4.1.42.0 (2024-07-18)
##### Dependencies: CrossPlatform 2.2.1.0, TSM 2.4.4-b3, TAMM Shared Libraries 2.2.2.0, MDM 3.5.2.10
[Added] Integrazione Landis Gyr ZMD Iec
[Added] Siemens: aggiunta lettura valori istantanei
[Added] ISKRA MT880: lettura dati fatturazione per dispositivi programmati in modo non standard
[Added] Actaris: aggiunta lettura picchi di fatturazione
[Changed] Landis: rimossa possibilità di scelta del periodo di fatturazione da interfaccia utente (come Actaris)
[Changed] Landis: utilizzo delle tabelle di mapping del SAC dello ShortName per versioni firmware già conosciute
[Fixed] Actaris: corretto indirizzamento del dispositivo 
[Fixed] Fiorentini SSM Icon 250 LTE: lettura e scrittura Plmn  

### 4.1.41.0 (2024-07-05)
##### Dependencies: CrossPlatform 2.2.1.0, TSM 2.4.4-b2, TAMM Shared Libraries 2.2.2.0, MDM 3.5.2.10
[Added] Integrazione Itron Gallus Net (H e K)
[Added] Integrazione Fiorentini Aquo LoRa (configuratore)
[Added] Integrazione Fiorentini Aquo NB-IoT (configuratore)
[Added] Test di comunicazione per meter GME: aggiunto dettaglio esito proveniente da MDM (cause errore)
[Fixed] Zenner NBIoT e GSM: correzioni a interfaccia grafica

### 4.1.40.0 (2024-06-28)
##### Dependencies: CrossPlatform 2.2.1.0, TSM 2.4.4-b2, TAMM Shared Libraries 2.2.2.0, MDM 3.5.2.10
[Changed] Fiorentini SSM Icon 250 LTE: Aggiornamento risorse relative alle cause chiusura della valvola
[Changed] Fiorentini SSM Icon 250 LTE: Disabilitazione voce di menu Aggiornamento FW
[Changed] Fiorentini SSM Icon 250 LTE: Disabilitazione funzionalità di Download Consumi Giornalieri in vista lettura dati
[Changed] Fiorentini SSM Icon 250 LTE: Aggiornamento mapping oggetto Stato della rete
[Added] Fiorentini SSM Icon 250 LTE: Gestione Prover Pulse Duration solo con profilo MG
[Fixed] Fiorentini SSM Icon 250 LTE: Corretta notifica della modifica del valore di capacità in vista Sostituzione batteria
[Fixed] Fiorentini SSM Icon NBIoT: aggiunto test di tenuta valvola tra le operazioni di menu
[Fixed] Fiorentini RSE NBIoT: ripristinato versioning

### 4.1.39.0 (2024-06-17)
##### Dependencies: CrossPlatform 2.2.1.0, TSM 2.4.4-b2, TAMM Shared Libraries 2.2.2.0, MDM 3.5.2.10
[Changed] Update TSM to 2.4.4-b2
[Changed] Fiorentini SSM Icon 250 LTE - Diagnostica dispositivo: gestione dell'informazione PP3 (GSM) Status 
[Added] Gestione delle timezone USA 
[Added] Dialog di esito attività su dispositivo: visualizzazione di un messaggio "Nessuna operazione eseguita" in caso di nessuna parametrizzazione modificata dall'utente 
[Added] Fiorentini SSM Icon 250 LTE: aggiunto modulo tecnico specifico TFUS per sblocco modello

### 4.1.38.0 (2024-05-29)
##### Dependencies: CrossPlatform 2.2.1.0, TSM 2.4.3, TAMM Shared Libraries 2.2.2.0, MDM 3.5.2.0
[Changed] Fiorentini SSM Icon 250 LTE: aggiornamento della mappatura dell'esito del test di comunicazione
[Changed] Fiorentini SSM Icon 250 LTE: aggiornamento obis code per gestione parametri del test di tenuta
[Fixed] Fiorentini SSM Icon 250 LTE: avvio del test di comunicazione con soltanto la verifica dell'esito
[Fixed] Time Picker: gestione formato mm:ss
[Fixed] Meter con protocollo DLMS LLS CP: utilizzo del campo password delle chiavi provenienti da MDM
[Added] Diagnostica: log della chiave, mediante specifico flag DeviceSecurityKeysClearContent impostato a TRUE inconfigurazione json, utilizzata dall'app per comunicazioni cifrate con meter
[Changed] GME: conversione dei consumi quartorari forniti dal meter (Tamm Shared Library) da W a Wh
[Changed] GME Landis Gyr: utilizzo di default delle mappe Obis-Short name presenti su Tamm Shared Library invece della lettura della mappa da meter

### 4.1.37.0 (2024-05-20)
##### Dependencies: CrossPlatform 2.2.1.0, TSM 2.4.3, TAMM Shared Libraries 2.2.2.0, MDM 3.5.2.0
[Added] Log delle chiamate al server
[Added] RemoteReadingId nei filtri di ricerca chiavi su server
[Added] Fiorentini SSM Icon 250 LTE: gestione Eventi aggiuntivi, traduzione ENG label Diagnostica corrente e allinemaneto allarmi
[Added] Fiorentini SSM Icon 250 LTE: aggiunto nuovo modello nel versioning per gestione del Prover Pulse anche con profilo IM
[Added] Fiorentini SSM Icon 250 LTE: aggiunto transizione di stato UNITS da 'Non Configurato' a 'Normale'
[Fixed] Fiorentini SSM Icon 250 LTE: corretta la PGV bitmask

### 4.1.36.0 (2024-05-14)
##### Dependencies: CrossPlatform 2.2.1.0, TSM 2.4.3, TAMM Shared Libraries 2.2.2.0, MDM 3.5.2.0
[Added] Meter elettrici BT: aggiunta chiave K1 in bundle SMPR
[Changed] Aggiornamento libreria TSM alla versione 2.4.3
[Fixed] Clock, dati di billing, misure istantanee, fix minori su Elster, EMH, Iskra MT831, Iskra MT850, Iskra MT880, Siemens, LandisGyr, Actaris
[Changed] E' stato modificato il timeout di attesa risposta dei download a 30s

### 4.1.35.0 (2024-04-22) 
##### Dependencies: CrossPlatform 2.0.13.0, TSM 2.4.2-b19, TAMM Shared Libraries 2.0.13.0, MDM 3.2.9.0
[Added] Verifica dell'abilitazione Bluetooth su smartphone/tablet Android, iOs, iPad in fase di connessione con dispositivi/sonde Bluetooth
[Added] Aggiunta dialog di selezione dispositivo di Comunicazione (BLT,USB) in schermata Impostazioni
[Changed] Visualizzazione risultato operazioni: esclusione operazioni non eseguite perché non necessarie
[Fixed] Risolto rallentamento in fase di caricamento dati della schermata Impostazioni causato della discovery bluetooth

### 4.1.34.0 (2024-04-09) 
##### Dependencies: CrossPlatform 2.0.13.0, TSM 2.4.2-b19, TAMM Shared Libraries 2.0.13.0, MDM 3.2.9.0
[Changed] TSM 2.4.2-b19 
[Changed] Icone app
[Changed] Fiorentini SSM Icon 250 LTE: evolutive varie
[Changed] Fiorentini SSM Icon 250 LTE: supporto BLE su Android 
[Added] Fiorentini SSM Icon 250 LTE: supporto iOs/iPad con BLE
[Changed] Lettura dati: download indipendente di ogni singola entità (eventi/consumi/letture)
[Added] Integrazione con funzionalità base (sviluppi in outsourcing) dei modelli: 
* Fiorentini RSV NBIoT
* Fiorentini SSM NTC NBIoT
* Texnopark RSE GSM
* MeterItalia EF/EG 4 GSM
* Zenner NBIOT
* Zenner GPRS
* Siconia NBIoT
* MeterItalia EF/EG 4 169
* Fiorentini SSM ICON NBIoT
* Fiorentini HME

### 4.1.33.0 (2024-03-06) 
##### Dependencies: CrossPlatform 2.0.13.0, TSM 2.4.2-b12, TAMM Shared Libraries 2.0.13.0, MDM 3.2.9.0
[Changed] TSM 2.4.2-b12
[Changed] SSM Icon 250 LTE: evolutive varie
[Changed] Compatibilità con Android 14 in attesa completamento modifica su TSM
[Added] Aggiunta di permessi aggiuntivi per gestire i pacchetti di app di terze parti
[Added] Integrazione dei modelli:
* Samgas RSE 169
* Samgas RSE GSM
* Samgas RSE NBIoT

### 4.1.30.0 (2024-01-17) 
##### Dependencies: CrossPlatform 2.0.13.0, TSM 2.4.2-b3, TAMM Shared Libraries 2.0.13.0, MDM 3.2.9.0
[Changed] Undo compatibilità con Android 14 in attesa completamento modifica su TSM
[Changed] Editabilità del parametro SOCKET_SELECTION di SM-PR in attività di posa

### 4.1.29.0 (2023-12-21)
##### Dependencies: CrossPlatform 2.0.13.0, TSM 2.4.2-b3, TAMM Shared Libraries 2.0.13.0, MDM 3.2.9.0
[Added] Compatibilità con Android 14
[Added] Gestione ordine di lavoro MDM con richiesta letture periodo corrente (ENEL LPC)

### 4.1.27.0 (2023-11-21)
##### Dependencies: CrossPlatform 2.0.13.0, TSM 2.4.2-b3, TAMM Shared Libraries 2.0.13.0, MDM 3.2.9.0
[Changed] Riduzione del timeout in fase di login a 10 secondi
[Added] Log con Tag, ottimizzazione del log con maggiori dettagli su test di comunicazione tramite MDM e download dati storici dai dispositivi
[Fixed] Distinzione fra annullamento operazioni da parte dell'operatore e fallimento per timeout (tutte le sonde)
[Fixed] Numero di serie IEC (registro 0.0.0)

### 4.1.26.0 (2023-11-21)
##### Dependencies: CrossPlatform 2.0.13.0, TSM 2.4.2-b3, TAMM Shared Libraries 2.0.13.0, MDM 3.2.9.0
[Fixed] Autenticazione Active Directory

### 4.1.25.0 (2023-10-25)
##### Dependencies: CrossPlatform 2.0.13.0, TSM 2.4.2-b3, TAMM Shared Libraries 2.0.13.0, MDM 3.2.9.0
[Added] Gestione Kapi/Kasi in attività Reset Diagnostica

### 4.1.23.0 (2023-10-06)
##### Dependencies: CrossPlatform 2.0.13.0, TSM 2.4.2-b3, TAMM Shared Libraries 2.0.13.0, MDM 3.2.9.0
[Changed] App2App: adeguamento regola di calcolo del modello (Diretto-Semidiretto) in attività di posa misuratore ENEL in base ai KAPI/KASI passati nel bundle

### 4.1.22.0 (2023-09-14)
##### Dependencies: CrossPlatform 2.0.13.0, TSM 2.4.2-b3, TAMM Shared Libraries 2.0.13.0, MDM 3.2.9.0
[Added] Gestione di nomi di pacchetto diversi di SM-PR a seconda del parametro MDM MeterProgrammerId
[Added] Gestione del valore APP2_SOFTWARE_VERSION restituito da SM-PR

### 4.1.20.0 (2023-08-22)
##### Dependencies: CrossPlatform 2.0.13.0, TSM 2.4.2-b3, TAMM Shared Libraries 2.0.13.0, MDM 3.2.9.0
[Changed] Ottimizzazione gestione errori protocollo IEC secondo lo standard IEC62056 (Iskra/Emh)
[Fixed] Iskra MT831, MT851, MT860: Lettura Numero di Serie
[Fixed] Duplicato elemento grafico in Tab Archivio Dati

### 4.1.19.0 (2023-08-09)
##### Dependencies: CrossPlatform 2.0.13.0, TSM 2.4.2-b3, TAMM Shared Libraries 2.0.13.0, MDM 3.2.9.0

[Added] Integrazione Emh: Installazione, download Curve, download totalizzatori
[Fixed] Iskra MT851: gestione orologio

### 4.1.18.0 (2023-07-03)
##### Dependencies: CrossPlatform 2.0.13.0, TSM 2.4.2-b3, TAMM Shared Libraries 2.0.13.0, MDM 3.2.9.0
[Fixed] Download Curve Siemens 7E

### 4.1.16.0 (2023-06-23)
##### Dependencies: CrossPlatform 2.0.13.0, TSM 2.4.2-b3, TAMM Shared Libraries 2.0.13.0, MDM 3.2.9.0
[Added] Integrazione Siemens 7E: Diagnostica, Installazione, Download Curve

### 4.1.15.0 (2023-06-15)
##### Dependencies: CrossPlatform 2.0.13.0, TSM 2.4.2-b3, TAMM Shared Libraries 2.0.13.0, MDM 3.2.9.0
[Added] Integrazione Enel SM-PR: acquisizione totalizzatori energia reattiva capacitiva immessa e prelevata
[Changed] Implementazione specifica App2App v.44

### 4.1.14.0 (2023-06-06)
##### Dependencies: CrossPlatform 2.0.6.0, TSM 2.4.2-b3, TAMM Shared Libraries 2.0.6.0, MDM 3.2.3.0
[Added] Iskra MT 831-851-860: download Curve

### 4.1.13.0 (2023-05-30)
##### Dependencies: CrossPlatform 2.0.6.0, TSM 2.4.2-b3, TAMM Shared Libraries 2.0.6.0, MDM 3.2.3.0
[Added] Elster A1700: log trame di tutte le comunicazioni
[Fixed] TSM 2.4.2-b3: ripristinata gestione USB in GME IEC

### 4.1.12.0 (2023-05-26)
##### Dependencies: CrossPlatform 2.0.6.0, TSM 2.4.2-b2, TAMM Shared Libraries 2.0.6.0, MDM 3.2.3.0
[Changed] Landis: Parsing curve e totalizzatori con librerie condivise con SAC
[Changed] Download Curve e Totalizzatori GME: selezione intervallo di date giorno/mese/anno per curve e mese/anno per totalizzatori
[Changed] Modelli GME IEC: editing password in selezione modello

### 4.1.11.0 (2023-04-07)
##### Dependencies: CrossPlatform 2.0.6.0, TSM 2.4.1-b7, TAMM Shared Libraries 2.0.6.0, MDM 3.2.3.0
[Added] Introduzione DLMS Short Name con gestione di cache su file per ottimizzare le prestazioni
[Changed] Landis: ottimizzazione curve e totalizzatori
[Fixed] Iskra: connessione IEC su tutti i modelli

### 4.1.10.0 (2023-03-30)
##### Dependencies: CrossPlatform 2.0.6.0, TSM 2.4.1-b7, TAMM Shared Libraries 2.0.6.0, MDM 3.2.3.0
-[Added] Elster A1700: utilizzo del baudrate 19200
-[Changed] Ottimizzazione in fase di caricamento delle viste Curve, Totalizzatori ed Eventi
-[Changed] Test di comunicazione GME: gestione del tasto back per chiusura finestra

### 4.1.9.0 (2023-03-16)
##### Dependencies: CrossPlatform 2.0.5.0, TSM 2.4.1-b3, TAMM Shared Libraries 1.0.40.0, MDM 3.2.3.0
-[Added] Test di comunicazione GME: aggiunto campo password
-[Changed] Localizzazione risorse in accordo con la lingua del telefono e dell'utente loggato

### 4.1.8.0 (2023-03-06)
##### Dependencies: CrossPlatform 1.0.37.0, TSM 2.4.1-b3, TAMM Shared Libraries 1.0.40.0, MDM 3.2.2.0 
-[Fixed] Elster: Totalizzatori e Calcolo Timestamp

### 4.1.4.0 (2023-02-27)
##### Dependencies: CrossPlatform 1.0.37.0, TSM 2.4.1-b3, TAMM Shared Libraries 1.0.40.0, MDM 3.2.2.0 
- [Added] Elster A1700: download curve quartorarie e totalizzatori mensili 
- [Added] Landis Gyr: selettore di protocollo in test di comunicazione
- [Added] Iskra MT880: download curve quartorarie, totalizzatori mensili ed eventi
- [Added] Esportazione curve quartorarie, totalizzatori mensili ed eventi su file csv


### 4.1.3.0 (2023-02-10)
##### Dependencies: CrossPlatform 1.0.37.0, TSM 2.4.1-b3, TAMM Shared Libraries 1.0.40.0, MDM 3.2.2.0 
- [Changed] Aggiornamento gestione parametro SMPR "SOCKET_SELECTION" in attività di Installazione e Sostituzione in emergenza: sempre visualizzato e reso opzionale. Il valore utilizzato è, nell'ordine di disponibilità, quello presente nell'odl o da configurazione default MDM o "1"

### 4.1.2.0 (2023-02-06)
##### Dependencies: CrossPlatform 1.0.37.0, TSM 2.4.1-b3, TAMM Shared Libraries 1.0.40.0, MDM 3.2.2.0 
- [Added] Selettore modello: possibilità di stabilire connessioni susseguenti
- [Added] Possibilità di rileggere i dati dal dispositivo
- [Changed] Impostazioni Clock su dispositivi GME
- [Added] Navigazione a funzionalità Walk-by
- [Added] Integrazione ricevitore Michael Rac
- [Added] Conversione Id dispositivo in Id Telelettura per compatibilità con Test di Comunicazione SAC Terranova 
- [Changed] Password di default per Iskra MT851
- [Changed] TSML versione 2.4.1-b3


### 4.1.1.0 (2023-01-25)
##### Dependencies: CrossPlatform 1.0.37.0, TSM 2.4.1-b2, TAMM Shared Libraries 1.0.40.0, MDM 3.2.2.0 
- [Added] Profilazione della pagina Home e del menu di navigazione
- [Added] Navigazione: unificato flusso AppToApp, StandAlone, Attività in campo
- [Changed] Integrazione modelli GME: Landis Zmd Fase 1 e 2, Actaris SL7000 Fase 1 e 2, Iskra MT831/851/860/880 Fase 1, Elster A1700 Fase 1, EMH LZQJ Fase 1, Cewe Prometer Fase 1
- [Added] Gestione parametri KAPI/KASI in input da attività AppToApp (vedi CR-BEA274)

### 4.0.23.0 (2022-11-30)
##### Dipendenze: MDM 3.1.36.1, TAMM Shared Libraries 1.0.22.0 
___

- [Added] Manage SMPR "ALTERNATIVE_POD_ID" parameter in CMO activities

### 4.0.22.0 (2022-11-15)
##### Dipendenze: MDM 3.1.31.0, TAMM Shared Libraries 1.0.22.0 
___

- [Added] Manage SMPR "SOCKET_SELECTION" parameter in Emergency Installation and Emergency Substitution activities

### 4.0.21.0 (2022-08-24)
##### Dipendenze: MDM 3.1.31.0, TAMM Shared Libraries 1.0.22.0 
___

- [Fixed] Manage Getis with serial number char 'X', Gesis with serial number char 'Y'

### 4.0.19.0 (2022-06-28)
##### Dipendenze: MDM 3.1.31.0, TAMM Shared Libraries 1.0.22.0 
___

- [Added] Tariff Reprogramming: POD, Available and Contractual Powers

### 4.0.18.0 (2022-03-29)
##### Dipendenze: MDM 3.1.31.0, TAMM Shared Libraries 1.0.22.0 
___

- [Changed] Supporto per il login con stesso nome utente dopo associazione ad altro account Active Directory

### 4.0.17.2 (2022-02-03)
##### Dipendenze: MDM 3.1.31.0, TAMM Shared Libraries 1.0.22.0 
___

- [Fixed] Corretto il nome della stringa DIAGNOSTICS_RESET relativa al comando MDM DiagnosticReset

### 4.0.17.1 (2022-02-03)
##### Dipendenze: MDM 3.1.31.0, TAMM Shared Libraries 1.0.22.0 
___

- [Fixed] Aggiunta gestione tariffe in attivita' "Installazione in emergenza" 

### 4.0.17.0 (2022-01-21)
##### Dependencies: MDM 3.1.31.0, TAMM Shared Libraries 1.0.20.0 
___

- [Changed] Gestione tariffe in attivita' Enel SM-PR (INS, RIP, ATT, VDC, RCT, DIS, DPM, APM, RPM, RCD)
- [Added] Gestione causali attivita' Enel SM-PR (RCD, RCL, RCT)
- [Changed] Adeguamento formato CONTRACT_START_DATE in bundle Enel SM-PR
- [Fixed] Login in App2App nel caso di utente con password o modalità (Forms/AD) modificate

### 4.0.16.0 (2021-12-22)
##### Dependencies: MDM 3.1.31.0, TAMM Shared Libraries 1.0.16.0 
___

- [Added] Abilitazione operativita' mobile in base ai permessi impostati sul portale
- [Added] Rinnovo licenza con login
- [Fix] Riconoscimento del cambio password in App2App se online
- [Added] Gestione della rimozione forzata di un misuratore mediante conferma operatore

### 4.0.15.0 (2021-12-10)
##### Dependencies: MDM 3.1.31.0, TAMM Shared Libraries 1.0.16.0 
___

- [Added] Accesso a funzionalità in base alla profilazione dell'utente
- [Changed] Modifica data delle letture di picco del periodo precedente
- [Changed] Invio informazioni di diagnostica contestuali alla richiesta delle chiavi del misuratore
- [Changed] Abilitazione al download delle chiavi parametrizzata nei processi

### 4.0.14.0 (2021-08-17)
##### Dependencies: MDM 3.1.28.0
___

- [Added] Gestione potenze contrattuali e disponibili da App terze in sostituzione in emergenza

### 4.0.13.0 (2021-07-22)
##### Dependencies: MDM 3.1.28.0
___

- [Added] Gestione del processo di sostituzione senza riprogrammazione

### 4.0.12.0 (2021-04-19)
- [Added] Gestione dispositivi Gism con identificativo 'Q'
- [Added] Gestione dispositivi Gist con identificativo 'P'

### 4.0.11.0 (2021-03-22)
- [Added] Sincronizzazione e utilizzo dei valori di default per CMO e PI forniti dal server MDM

### 4.0.10.0 (2021-02-24)
- [Changed] Navigazione per Impostazioni in tutte le viste
- [Fixed] Dati in uscita in stand-alone 
- [Fixed] Blocco vista letture

### 4.0.9.2 (2021-02-16)
- [Changed] Gestione HandHeld in licenze

### 4.0.9.1 (2021-01-27)
- [Changed] Rimozione duplicazione di account su database in contesto multi-azienda
- [Changed] Logout consentito in attivita' create in campo

### 4.0.9.0 (2021-01-25)
- [Fixed] Match numero di serie passato da WFA con modelli raggruppati (diretto/semidiretto)

### 4.0.8.0 (2021-01-24)
- [Fixed] SM-PR: Inizializzazione componenti grafici in attivita' Installazione
- [Changed] Allineamento a Xamarin Forms 5

### 4.0.7.0 (2021-01-21)
- [Changed] SM-PR: DISI sostituito con DISI_INFORCE
- [Changed] SM-PR: Cambio tipo BIDIR (bool -> 1 = monodirezionale, 2 = bidirezionale)

### 4.0.6.0 (2021-01-12)
- [Changed] Android Loader per navigazione fra pagine
- [Fixed] Serializzazione su Android

### 4.0.5.0 (2021-01-12)
- [Changed] Android Loader per navigazione fra pagine
- [Fixed] Serializzazione su Android

### 4.0.4.0 (2021-01-11)
- [Changed] Abilitazione viste modello Samgas NBIoT
- [Fixed] Invio punto di misura al server per attivita' create in campo
- [Fixed] Invio bundle di risposta SM-PR al server

### 4.0.3.0 (2020-12-31)
- [Changed] Allineamento a SM-PR su nome punto di misura (CUST_ID_INFORCE in output, SUPPLY_POINT_ID in input)
- [Changed] Allineamento a SM-PR su spazi in eccesso su valore punto di misura

### 4.0.2.0 (2020-12-23)
- [Changed] Allineamento a SM-PR su nome punto di misura (CUST_ID_INFORCE anziché SUPPLY_POINT_ID)
- [Changed] Abilitazione dei moduli stand-alone, AppToApp e attivita' create in campo
- [Fix] Comunicazione a MDM dei bundle sessioni comunicazione attivita' create in campo

### 4.0.1.0 (2020-12-10)
- [Added] Librerie supporto Android X
- [Added] Toast e log per Download attivita', Upload attivita', Download Chiavi, Importazione Chiavi
- [Fixed] File Picker per importazione chiavi
- [Fixed] Visualizzazione Data Scadenza attivita'

### 4.0.0.109 (2020-12-09)
- [Fixed] Interfaccia utente e localizzazione

### 4.0.0.108 (2020-12-09)
- [Changed] Costruzione ExternalId in attivita' create in campo con padding
- [Fixed] Risorse localizzate: impostazione secondo lingua dell'utente o in difetto quella del dispositivo

### 4.0.0.107 (2020-12-07)
- [Added] Prefisso localizzato "Scad. " alla data di scadenza delle attivita'
- [Changed] Log su file giornalieri nel formato TAMMMobile_yyyyMMdd.log
- [Fixed] Visualizzazione Data Scadenza Licenza
- [Fixed Visualizzazione e log della versione in formato Major.Minor.Revision.Build

### 4.0.0.106 (2020-12-04)
- [Added] Creazione attivita' di campo di tipo Reset Diagnostica
- [Added] Gestione Note operatore
- [Added] Gestione Data scadenza attivita'
- [Added] Upload attivita' di campo
- [Changed] Applicazione stili Material Design

### 4.0.0.100 (2020-11-17)
- [Added] Creazione attivita' in campo di tipo Installazione in emergenza 
- [Added] Incoming and outcoming bundle returned to AppToApp
- [Fixed] Protocol in MDM outcome data

### 1.3.2 (2020-03-11)
Release for Edyna
- [Added] Manage GESIS devices with J identifier

### 1.3.1.1 (2019-12-16)
Release for Edyna
- [Fixed] LPP Readings mapping (use PREVIOUS instead of CURRENT SM-PR bundle's keys)

### 1.3.1.0 (2019-11-22)
Release for Edyna
- [Changed] Hardware back button disabled
- [Added] Script to update the database in order to use https instead of http as protocol

### 1.3.0.0 (2019-11-22)
- First release for Edyna 

### 1.0.0.0 (2018-10-05)
- First release on Windows platform 