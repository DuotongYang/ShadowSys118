# TODO List for ShadowSys118 Solution

Zhijie Nie

Revised on 2017-08-09

## Program Development
* (C#) Verify Action's logic before execute it
* (Python) Use a better PSSE library for python codes


## Documentation
### `UpdateSystemSettings`

| ECA Analytic | FramesPerSecond | LagTime | LeadTime | Publication Time | 
| :----------- | :-------------- | :------ | :------- | :--------------- |
| ShadowSys118 | 1 | 1 | 4 | | |
| LVC118_test  | 1 | 2 | 1 | | |
| LVC118       | 1 | 2 | 1 | | |


## Need to Knows
* TestHarness is just a tool for developing an analytic - the actual end product will be an 
**installable Windows service**.


## Issues


## Completed Tasks
* (PSS/E) Choose a localized area for voltage control in 118-bus System
* (openECA) Reserve **ActionsChannel** for Actions of RAISE, LOWER, CLOSE, TRIP
* (openECA) Create **Measurements** for IEEE 118-bus System by adding queries to `SampleDataSet.sql` 
script
* (openECA) Backup `ConnectionString` for Input Adapters
* (C#) Include ResetSignal for test initialization
* (C#/Python) Add 118 Voltage Magnitude measurements to Outputs
* (C#) Test Pseudo-RVC action signals to execute control using `CsvInputAdapters`


## Backup - Input Adapters `ConnectionString` 
### `SS118TESTX` for LVC
```
Filename=C:\Program Files\openECA\Server\20170630_ShadowSys_LoadPattern_test1.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:62; 2 = PPA:41}; InputInterval=1000
```
```
Filename=C:\Program Files\openECA\Server\20170630_ShadowSys_LoadPattern_test2.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:62; 2 = PPA:41}; InputInterval=1000
```
```
Filename=C:\Program Files\openECA\Server\20170630_ShadowSys_LoadPattern_test3.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:62; 2 = PPA:41}; InputInterval=1000
```
```
Filename=C:\Program Files\openECA\Server\20170613_ShadowSys_Inputs.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:62; 2 = PPA:41}; InputInterval=1000
```


### PSDLVC118CSV
#### Fixed Load 1
```
Filename=C:\Program Files\openECA\Server\20170627_PseudoLVCSignals.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:42; 2 = PPA:43; 3 = PPA:44; 4 = PPA:45; 5 = PPA:46; 6 = PPA:47}; InputInterval=500
```
#### Fixed Load 2
```
Filename=C:\Program Files\openECA\Server\20170703_PseudoLVCSignals.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:62; 2 = PPA:41; 3 = PPA:42; 4 = PPA:43; 5 = PPA:44; 6 = PPA:45; 7 = PPA:46; 8 = PPA:47}; InputInterval=1000
```
#### Variable Load (External Input for PPA:41)
```
Filename=C:\Program Files\openECA\Server\20170703_PseudoLVCSignals.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:62; 3 = PPA:42; 4 = PPA:43; 5 = PPA:44; 6 = PPA:45; 7 = PPA:46; 8 = PPA:47}; InputInterval=1000
```
```
Filename=C:\Program Files\openECA\Server\20170714_PseudoLVCSignals.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:62; 3 = PPA:42; 4 = PPA:43; 5 = PPA:44; 6 = PPA:45; 7 = PPA:46; 8 = PPA:47}; InputInterval=1000
```


### PSDRVC118CSV
#### Variable Load (External Input for PPA:41)
```
Filename=C:\Program Files\openECA\Server\20170711_PseudoRVCSignals.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:63; 2 = PPA:64; 3 = PPA:65; 4 = PPA:66; 5 = PPA:67; 6 = PPA:68; 7 = PPA:69; 8 = PPA:70; 9 = PPA:71; 10 = PPA:72; 11 = PPA:73; 12 = PPA:74}; InputInterval=1000
```
```
Filename=C:\Program Files\openECA\Server\20170712_PseudoRVCSignals.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:63; 2 = PPA:64; 3 = PPA:65; 4 = PPA:66; 5 = PPA:67; 6 = PPA:68; 7 = PPA:69; 8 = PPA:70; 9 = PPA:71; 10 = PPA:72; 11 = PPA:73; 12 = PPA:74; 13 = PPA:41; 14 = PPA:62}; InputInterval=1000
```


#### Fixed Load (ResetSignal included)
```
Filename=C:\Program Files\openECA\Server\20170712_PseudoRVCSignals.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:63; 2 = PPA:64; 3 = PPA:65; 4 = PPA:66; 5 = PPA:67; 6 = PPA:68; 7 = PPA:69; 8 = PPA:70; 9 = PPA:71; 10 = PPA:72; 11 = PPA:73; 12 = PPA:74; 13 = PPA:41; 14 = PPA:62}; InputInterval=1000
```

### PSDMEAS118CSV
```
Filename=C:\Program Files\openECA\Server\20170713_PseudoRVCMeasurements.csv; AutoRepeat=True; SimulateTimestamp=True; TransverseMode=True; ColumnMappings={0 = Timestamp; 1 = PPA:81; 2 = PPA:82; 3 = PPA:83; 4 = PPA:84; 5 = PPA:85; 6 = PPA:86; 7 = PPA:87; 8 = PPA:88; 9 = PPA:89; 10 = PPA:90; 11 = PPA:91; 12 = PPA:92; 13 = PPA:93; 14 = PPA:94; 15 = PPA:95; 16 = PPA:96; 17 = PPA:97; 18 = PPA:98; 19 = PPA:99; 20 = PPA:100; 21 = PPA:101; 22 = PPA:102; 23 = PPA:103; 24 = PPA:104; 25 = PPA:105; 26 = PPA:106; 27 = PPA:107; 28 = PPA:108; 29 = PPA:109; 30 = PPA:110; 31 = PPA:111; 32 = PPA:112; 33 = PPA:113; 34 = PPA:114; 35 = PPA:115; 36 = PPA:116; 37 = PPA:117; 38 = PPA:118; 39 = PPA:119; 40 = PPA:120; 41 = PPA:121; 42 = PPA:122; 43 = PPA:123; 44 = PPA:124; 45 = PPA:125; 46 = PPA:126; 47 = PPA:127; 48 = PPA:128; 49 = PPA:129; 50 = PPA:130; 51 = PPA:131; 52 = PPA:132; 53 = PPA:133; 54 = PPA:134; 55 = PPA:135; 56 = PPA:136; 57 = PPA:137; 58 = PPA:138; 59 = PPA:139; 60 = PPA:140; 61 = PPA:141; 62 = PPA:142; 63 = PPA:143; 64 = PPA:144; 65 = PPA:145; 66 = PPA:146; 67 = PPA:147; 68 = PPA:148; 69 = PPA:149; 70 = PPA:150; 71 = PPA:151; 72 = PPA:152; 73 = PPA:153; 74 = PPA:154; 75 = PPA:155; 76 = PPA:156; 77 = PPA:157; 78 = PPA:158; 79 = PPA:159; 80 = PPA:160; 81 = PPA:161; 82 = PPA:162; 83 = PPA:163; 84 = PPA:164; 85 = PPA:165; 86 = PPA:166; 87 = PPA:167; 88 = PPA:168; 89 = PPA:169; 90 = PPA:170; 91 = PPA:171; 92 = PPA:172; 93 = PPA:173; 94 = PPA:174; 95 = PPA:175; 96 = PPA:176; 97 = PPA:177; 98 = PPA:178; 99 = PPA:179; 100 = PPA:180; 101 = PPA:181; 102 = PPA:182; 103 = PPA:183; 104 = PPA:184; 105 = PPA:185; 106 = PPA:186; 107 = PPA:187; 108 = PPA:188; 109 = PPA:189; 110 = PPA:190; 111 = PPA:191; 112 = PPA:192; 113 = PPA:193; 114 = PPA:194; 115 = PPA:195; 116 = PPA:196; 117 = PPA:197; 118 = PPA:198; 119 = PPA:75; 120 = PPA:76; 121 = PPA:77; 122 = PPA:78; 123 = PPA:79; 124 = PPA:80}; InputInterval=1000
```

## Backups
#### SQL Script Supplement
```sql
-- Shadow System using 118 bus system (ShadowSys118) for LVC
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:LOADINCRE', 9, NULL, 'SS118-LOADINCRE', 'Shadow System for 118-bus system - Load Increment in percentage', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTTXRAISE', 9, NULL, 'SS118-ACTTXRAISE', 'Shadow System for 118-bus system - Action flag of raising load-tap-changer ActTxRaise', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTTXLOWER', 9, NULL, 'SS118-ACTTXLOWER', 'Shadow System for 118-bus system - Action flag of lowering load-tap-changer ActTxLower', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSN1CLOSE', 9, NULL, 'SS118-ACTSN1CLOSE', 'Shadow System for 118-bus system - Action flag of closing capacitor bank 1 circuit breaker ActSn1Close', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSN1TRIP', 9, NULL, 'SS118-ACTSN1TRIP', 'Shadow System for 118-bus system - Action flag of tripping capacitor bank 1 circuit breaker ActSn1Trip', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSN2CLOSE', 9, NULL, 'SS118-ACTSN2CLOSE', 'Shadow System for 118-bus system - Action flag of closing capacitor bank 2 circuit breaker ActSn2Close', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSN2TRIP', 9, NULL, 'SS118-ACTSN2TRIP', 'Shadow System for 118-bus system - Action flag of tripping capacitor bank 2 circuit breaker ActSn2Trip', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:STATETXTAPV', 9, NULL, 'SS118-STATETXTAPV', 'Shadow System for 118-bus system - Transformer load-tap-changer state value StateTxTapV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:STATESN1CAPBKRV', 9, NULL, 'SS118-STATESN1CAPBKRV', 'Shadow System for 118-bus system - Capacitor bank 1 shunt circuit breaker state value StateSn1CapBkrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:STATESN2CAPBKRV', 9, NULL, 'SS118-STATESN2CAPBKRV', 'Shadow System for 118-bus system - Capacitor bank 2 shunt circuit breaker state value StateSn2CapBkrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:STATESN1BUSBKRV', 9, NULL, 'SS118-STATESN1BUSBKRV', 'Shadow System for 118-bus system - Capacitor bank 1 bus circuit breaker state value StateSn1BusBkrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:STATESN2BUSBKRV', 9, NULL, 'SS118-STATESN2BUSBKRV', 'Shadow System for 118-bus system - Capacitor bank 2 bus circuit breaker state value StateSn2BusBkrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASTXVOLTV', 3, NULL, 'SS118-MEASTXVOLTV', 'Shadow System for 118-bus system - Transformer high-side bus voltage value MeasTxVoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASSN1VOLTV', 3, NULL, 'SS118-MEASSN1VOLTV', 'Shadow System for 118-bus system - Capacitor bank 1  local bus voltage value MeasSn1VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASSN2VOLTV', 3, NULL, 'SS118-MEASSN2VOLTV', 'Shadow System for 118-bus system - Capacitor bank 2  local bus voltage value MeasSn2VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASTXMWV', 10, NULL, 'SS118-MEASTXMWV', 'Shadow System for 118-bus system -  Transformer transferred active power MeasTxMwV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASTXMVRV', 10, NULL, 'SS118-MEASTXMVRV', 'Shadow System for 118-bus system -  Transformer transferred reactive power MeasTxMvrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASGN1MWV', 10, NULL, 'SS118-MEASGN1MWV', 'Shadow System for 118-bus system -  Generator 1 transferred active power MeasGn1MwV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASGN1MVRV', 10, NULL, 'SS118-MEASGN1MVRV', 'Shadow System for 118-bus system -  Generator 1 transferred reactive power MeasGn1MvrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASGN2MWV', 10, NULL, 'SS118-MEASGN2MWV', 'Shadow System for 118-bus system -  Generator 2 transferred active power MeasGn2MwV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASGN2MVRV', 10, NULL, 'SS118-MEASGN2MVRV', 'Shadow System for 118-bus system -  Generator 2 transferred reactive power MeasGn2MvrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:RESET', 9, NULL, 'SS118-RESET', 'Shadow System for 118-bus system -  Reset Signal to read initial system configuration', 1);

-- Shadow System using 118 bus system(ShadowSys118) for RVC
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSNB34CLOSE', 9, NULL, 'SS118-ACTSNB34CLOSE', 'Shadow System for 118-bus system - Action flag of closing Capacitor Bank at bus 34 ActSnB34Close', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSNB44CLOSE', 9, NULL, 'SS118-ACTSNB44CLOSE', 'Shadow System for 118-bus system - Action flag of closing Capacitor Bank at bus 44 ActSnB44Close', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSNB45CLOSE', 9, NULL, 'SS118-ACTSNB45CLOSE', 'Shadow System for 118-bus system - Action flag of closing Capacitor Bank at bus 45 ActSnB45Close', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSNB48CLOSE', 9, NULL, 'SS118-ACTSNB48CLOSE', 'Shadow System for 118-bus system - Action flag of closing Capacitor Bank at bus 48 ActSnB48Close', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSNB74CLOSE', 9, NULL, 'SS118-ACTSNB74CLOSE', 'Shadow System for 118-bus system - Action flag of closing Capacitor Bank at bus 74 ActSnB74Close', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSNB105CLOSE', 9, NULL, 'SS118-ACTSNB105CLOSE', 'Shadow System for 118-bus system - Action flag of closing Capacitor Bank at bus 105 ActSnB105Close', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSNB34TRIP', 9, NULL, 'SS118-ACTSNB34TRIP', 'Shadow System for 118-bus system - Action flag of tripping Capacitor Bank at bus 34 ActSnB34Trip', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSNB44TRIP', 9, NULL, 'SS118-ACTSNB44TRIP', 'Shadow System for 118-bus system - Action flag of tripping Capacitor Bank at bus 44 ActSnB44Trip', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSNB45TRIP', 9, NULL, 'SS118-ACTSNB45TRIP', 'Shadow System for 118-bus system - Action flag of tripping Capacitor Bank at bus 45 ActSnB45Trip', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSNB48TRIP', 9, NULL, 'SS118-ACTSNB48TRIP', 'Shadow System for 118-bus system - Action flag of tripping Capacitor Bank at bus 48 ActSnB48Trip', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSNB74TRIP', 9, NULL, 'SS118-ACTSNB74TRIP', 'Shadow System for 118-bus system - Action flag of tripping Capacitor Bank at bus 74 ActSnB74Trip', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:ACTSNB105TRIP', 9, NULL, 'SS118-ACTSNB105TRIP', 'Shadow System for 118-bus system - Action flag of tripping Capacitor Bank at bus 105 ActSnB105Trip', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:STATESNB34CAPBKRV', 9, NULL, 'SS118-STATESNB34CAPBKRV', 'Shadow System for 118-bus system - Capacitor Bank at bus 34 circuit breaker state value StateSnB34CapBkrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:STATESNB44CAPBKRV', 9, NULL, 'SS118-STATESNB44CAPBKRV', 'Shadow System for 118-bus system - Capacitor Bank at bus 44 circuit breaker state value StateSnB44CapBkrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:STATESNB45CAPBKRV', 9, NULL, 'SS118-STATESNB45CAPBKRV', 'Shadow System for 118-bus system - Capacitor Bank at bus 45 circuit breaker state value StateSnB45CapBkrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:STATESNB48CAPBKRV', 9, NULL, 'SS118-STATESNB48CAPBKRV', 'Shadow System for 118-bus system - Capacitor Bank at bus 48 circuit breaker state value StateSnB48CapBkrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:STATESNB74CAPBKRV', 9, NULL, 'SS118-STATESNB74CAPBKRV', 'Shadow System for 118-bus system - Capacitor Bank at bus 74 circuit breaker state value StateSnB74CapBkrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:STATESNB105CAPBKRV', 9, NULL, 'SS118-STATESNB105CAPBKRV', 'Shadow System for 118-bus system - Capacitor Bank at bus 105 circuit breaker state value StateSnB105CapBkrV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB1VOLTV', 3, NULL, 'SS118-MEASB1VOLTV', 'Shadow System for 118-bus system - Bus 1 Voltage Magnitude MeasB1VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB2VOLTV', 3, NULL, 'SS118-MEASB2VOLTV', 'Shadow System for 118-bus system - Bus 2 Voltage Magnitude MeasB2VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB3VOLTV', 3, NULL, 'SS118-MEASB3VOLTV', 'Shadow System for 118-bus system - Bus 3 Voltage Magnitude MeasB3VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB4VOLTV', 3, NULL, 'SS118-MEASB4VOLTV', 'Shadow System for 118-bus system - Bus 4 Voltage Magnitude MeasB4VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB5VOLTV', 3, NULL, 'SS118-MEASB5VOLTV', 'Shadow System for 118-bus system - Bus 5 Voltage Magnitude MeasB5VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB6VOLTV', 3, NULL, 'SS118-MEASB6VOLTV', 'Shadow System for 118-bus system - Bus 6 Voltage Magnitude MeasB6VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB7VOLTV', 3, NULL, 'SS118-MEASB7VOLTV', 'Shadow System for 118-bus system - Bus 7 Voltage Magnitude MeasB7VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB8VOLTV', 3, NULL, 'SS118-MEASB8VOLTV', 'Shadow System for 118-bus system - Bus 8 Voltage Magnitude MeasB8VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB9VOLTV', 3, NULL, 'SS118-MEASB9VOLTV', 'Shadow System for 118-bus system - Bus 9 Voltage Magnitude MeasB9VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB10VOLTV', 3, NULL, 'SS118-MEASB10VOLTV', 'Shadow System for 118-bus system - Bus 10 Voltage Magnitude MeasB10VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB11VOLTV', 3, NULL, 'SS118-MEASB11VOLTV', 'Shadow System for 118-bus system - Bus 11 Voltage Magnitude MeasB11VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB12VOLTV', 3, NULL, 'SS118-MEASB12VOLTV', 'Shadow System for 118-bus system - Bus 12 Voltage Magnitude MeasB12VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB13VOLTV', 3, NULL, 'SS118-MEASB13VOLTV', 'Shadow System for 118-bus system - Bus 13 Voltage Magnitude MeasB13VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB14VOLTV', 3, NULL, 'SS118-MEASB14VOLTV', 'Shadow System for 118-bus system - Bus 14 Voltage Magnitude MeasB14VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB15VOLTV', 3, NULL, 'SS118-MEASB15VOLTV', 'Shadow System for 118-bus system - Bus 15 Voltage Magnitude MeasB15VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB16VOLTV', 3, NULL, 'SS118-MEASB16VOLTV', 'Shadow System for 118-bus system - Bus 16 Voltage Magnitude MeasB16VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB17VOLTV', 3, NULL, 'SS118-MEASB17VOLTV', 'Shadow System for 118-bus system - Bus 17 Voltage Magnitude MeasB17VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB18VOLTV', 3, NULL, 'SS118-MEASB18VOLTV', 'Shadow System for 118-bus system - Bus 18 Voltage Magnitude MeasB18VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB19VOLTV', 3, NULL, 'SS118-MEASB19VOLTV', 'Shadow System for 118-bus system - Bus 19 Voltage Magnitude MeasB19VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB20VOLTV', 3, NULL, 'SS118-MEASB20VOLTV', 'Shadow System for 118-bus system - Bus 20 Voltage Magnitude MeasB20VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB21VOLTV', 3, NULL, 'SS118-MEASB21VOLTV', 'Shadow System for 118-bus system - Bus 21 Voltage Magnitude MeasB21VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB22VOLTV', 3, NULL, 'SS118-MEASB22VOLTV', 'Shadow System for 118-bus system - Bus 22 Voltage Magnitude MeasB22VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB23VOLTV', 3, NULL, 'SS118-MEASB23VOLTV', 'Shadow System for 118-bus system - Bus 23 Voltage Magnitude MeasB23VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB24VOLTV', 3, NULL, 'SS118-MEASB24VOLTV', 'Shadow System for 118-bus system - Bus 24 Voltage Magnitude MeasB24VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB25VOLTV', 3, NULL, 'SS118-MEASB25VOLTV', 'Shadow System for 118-bus system - Bus 25 Voltage Magnitude MeasB25VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB26VOLTV', 3, NULL, 'SS118-MEASB26VOLTV', 'Shadow System for 118-bus system - Bus 26 Voltage Magnitude MeasB26VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB27VOLTV', 3, NULL, 'SS118-MEASB27VOLTV', 'Shadow System for 118-bus system - Bus 27 Voltage Magnitude MeasB27VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB28VOLTV', 3, NULL, 'SS118-MEASB28VOLTV', 'Shadow System for 118-bus system - Bus 28 Voltage Magnitude MeasB28VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB29VOLTV', 3, NULL, 'SS118-MEASB29VOLTV', 'Shadow System for 118-bus system - Bus 29 Voltage Magnitude MeasB29VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB30VOLTV', 3, NULL, 'SS118-MEASB30VOLTV', 'Shadow System for 118-bus system - Bus 30 Voltage Magnitude MeasB30VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB31VOLTV', 3, NULL, 'SS118-MEASB31VOLTV', 'Shadow System for 118-bus system - Bus 31 Voltage Magnitude MeasB31VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB32VOLTV', 3, NULL, 'SS118-MEASB32VOLTV', 'Shadow System for 118-bus system - Bus 32 Voltage Magnitude MeasB32VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB33VOLTV', 3, NULL, 'SS118-MEASB33VOLTV', 'Shadow System for 118-bus system - Bus 33 Voltage Magnitude MeasB33VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB34VOLTV', 3, NULL, 'SS118-MEASB34VOLTV', 'Shadow System for 118-bus system - Bus 34 Voltage Magnitude MeasB34VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB35VOLTV', 3, NULL, 'SS118-MEASB35VOLTV', 'Shadow System for 118-bus system - Bus 35 Voltage Magnitude MeasB35VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB36VOLTV', 3, NULL, 'SS118-MEASB36VOLTV', 'Shadow System for 118-bus system - Bus 36 Voltage Magnitude MeasB36VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB37VOLTV', 3, NULL, 'SS118-MEASB37VOLTV', 'Shadow System for 118-bus system - Bus 37 Voltage Magnitude MeasB37VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB38VOLTV', 3, NULL, 'SS118-MEASB38VOLTV', 'Shadow System for 118-bus system - Bus 38 Voltage Magnitude MeasB38VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB39VOLTV', 3, NULL, 'SS118-MEASB39VOLTV', 'Shadow System for 118-bus system - Bus 39 Voltage Magnitude MeasB39VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB40VOLTV', 3, NULL, 'SS118-MEASB40VOLTV', 'Shadow System for 118-bus system - Bus 40 Voltage Magnitude MeasB40VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB41VOLTV', 3, NULL, 'SS118-MEASB41VOLTV', 'Shadow System for 118-bus system - Bus 41 Voltage Magnitude MeasB41VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB42VOLTV', 3, NULL, 'SS118-MEASB42VOLTV', 'Shadow System for 118-bus system - Bus 42 Voltage Magnitude MeasB42VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB43VOLTV', 3, NULL, 'SS118-MEASB43VOLTV', 'Shadow System for 118-bus system - Bus 43 Voltage Magnitude MeasB43VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB44VOLTV', 3, NULL, 'SS118-MEASB44VOLTV', 'Shadow System for 118-bus system - Bus 44 Voltage Magnitude MeasB44VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB45VOLTV', 3, NULL, 'SS118-MEASB45VOLTV', 'Shadow System for 118-bus system - Bus 45 Voltage Magnitude MeasB45VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB46VOLTV', 3, NULL, 'SS118-MEASB46VOLTV', 'Shadow System for 118-bus system - Bus 46 Voltage Magnitude MeasB46VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB47VOLTV', 3, NULL, 'SS118-MEASB47VOLTV', 'Shadow System for 118-bus system - Bus 47 Voltage Magnitude MeasB47VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB48VOLTV', 3, NULL, 'SS118-MEASB48VOLTV', 'Shadow System for 118-bus system - Bus 48 Voltage Magnitude MeasB48VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB49VOLTV', 3, NULL, 'SS118-MEASB49VOLTV', 'Shadow System for 118-bus system - Bus 49 Voltage Magnitude MeasB49VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB50VOLTV', 3, NULL, 'SS118-MEASB50VOLTV', 'Shadow System for 118-bus system - Bus 50 Voltage Magnitude MeasB50VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB51VOLTV', 3, NULL, 'SS118-MEASB51VOLTV', 'Shadow System for 118-bus system - Bus 51 Voltage Magnitude MeasB51VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB52VOLTV', 3, NULL, 'SS118-MEASB52VOLTV', 'Shadow System for 118-bus system - Bus 52 Voltage Magnitude MeasB52VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB53VOLTV', 3, NULL, 'SS118-MEASB53VOLTV', 'Shadow System for 118-bus system - Bus 53 Voltage Magnitude MeasB53VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB54VOLTV', 3, NULL, 'SS118-MEASB54VOLTV', 'Shadow System for 118-bus system - Bus 54 Voltage Magnitude MeasB54VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB55VOLTV', 3, NULL, 'SS118-MEASB55VOLTV', 'Shadow System for 118-bus system - Bus 55 Voltage Magnitude MeasB55VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB56VOLTV', 3, NULL, 'SS118-MEASB56VOLTV', 'Shadow System for 118-bus system - Bus 56 Voltage Magnitude MeasB56VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB57VOLTV', 3, NULL, 'SS118-MEASB57VOLTV', 'Shadow System for 118-bus system - Bus 57 Voltage Magnitude MeasB57VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB58VOLTV', 3, NULL, 'SS118-MEASB58VOLTV', 'Shadow System for 118-bus system - Bus 58 Voltage Magnitude MeasB58VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB59VOLTV', 3, NULL, 'SS118-MEASB59VOLTV', 'Shadow System for 118-bus system - Bus 59 Voltage Magnitude MeasB59VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB60VOLTV', 3, NULL, 'SS118-MEASB60VOLTV', 'Shadow System for 118-bus system - Bus 60 Voltage Magnitude MeasB60VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB61VOLTV', 3, NULL, 'SS118-MEASB61VOLTV', 'Shadow System for 118-bus system - Bus 61 Voltage Magnitude MeasB61VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB62VOLTV', 3, NULL, 'SS118-MEASB62VOLTV', 'Shadow System for 118-bus system - Bus 62 Voltage Magnitude MeasB62VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB63VOLTV', 3, NULL, 'SS118-MEASB63VOLTV', 'Shadow System for 118-bus system - Bus 63 Voltage Magnitude MeasB63VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB64VOLTV', 3, NULL, 'SS118-MEASB64VOLTV', 'Shadow System for 118-bus system - Bus 64 Voltage Magnitude MeasB64VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB65VOLTV', 3, NULL, 'SS118-MEASB65VOLTV', 'Shadow System for 118-bus system - Bus 65 Voltage Magnitude MeasB65VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB66VOLTV', 3, NULL, 'SS118-MEASB66VOLTV', 'Shadow System for 118-bus system - Bus 66 Voltage Magnitude MeasB66VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB67VOLTV', 3, NULL, 'SS118-MEASB67VOLTV', 'Shadow System for 118-bus system - Bus 67 Voltage Magnitude MeasB67VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB68VOLTV', 3, NULL, 'SS118-MEASB68VOLTV', 'Shadow System for 118-bus system - Bus 68 Voltage Magnitude MeasB68VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB69VOLTV', 3, NULL, 'SS118-MEASB69VOLTV', 'Shadow System for 118-bus system - Bus 69 Voltage Magnitude MeasB69VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB70VOLTV', 3, NULL, 'SS118-MEASB70VOLTV', 'Shadow System for 118-bus system - Bus 70 Voltage Magnitude MeasB70VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB71VOLTV', 3, NULL, 'SS118-MEASB71VOLTV', 'Shadow System for 118-bus system - Bus 71 Voltage Magnitude MeasB71VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB72VOLTV', 3, NULL, 'SS118-MEASB72VOLTV', 'Shadow System for 118-bus system - Bus 72 Voltage Magnitude MeasB72VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB73VOLTV', 3, NULL, 'SS118-MEASB73VOLTV', 'Shadow System for 118-bus system - Bus 73 Voltage Magnitude MeasB73VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB74VOLTV', 3, NULL, 'SS118-MEASB74VOLTV', 'Shadow System for 118-bus system - Bus 74 Voltage Magnitude MeasB74VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB75VOLTV', 3, NULL, 'SS118-MEASB75VOLTV', 'Shadow System for 118-bus system - Bus 75 Voltage Magnitude MeasB75VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB76VOLTV', 3, NULL, 'SS118-MEASB76VOLTV', 'Shadow System for 118-bus system - Bus 76 Voltage Magnitude MeasB76VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB77VOLTV', 3, NULL, 'SS118-MEASB77VOLTV', 'Shadow System for 118-bus system - Bus 77 Voltage Magnitude MeasB77VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB78VOLTV', 3, NULL, 'SS118-MEASB78VOLTV', 'Shadow System for 118-bus system - Bus 78 Voltage Magnitude MeasB78VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB79VOLTV', 3, NULL, 'SS118-MEASB79VOLTV', 'Shadow System for 118-bus system - Bus 79 Voltage Magnitude MeasB79VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB80VOLTV', 3, NULL, 'SS118-MEASB80VOLTV', 'Shadow System for 118-bus system - Bus 80 Voltage Magnitude MeasB80VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB81VOLTV', 3, NULL, 'SS118-MEASB81VOLTV', 'Shadow System for 118-bus system - Bus 81 Voltage Magnitude MeasB81VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB82VOLTV', 3, NULL, 'SS118-MEASB82VOLTV', 'Shadow System for 118-bus system - Bus 82 Voltage Magnitude MeasB82VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB83VOLTV', 3, NULL, 'SS118-MEASB83VOLTV', 'Shadow System for 118-bus system - Bus 83 Voltage Magnitude MeasB83VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB84VOLTV', 3, NULL, 'SS118-MEASB84VOLTV', 'Shadow System for 118-bus system - Bus 84 Voltage Magnitude MeasB84VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB85VOLTV', 3, NULL, 'SS118-MEASB85VOLTV', 'Shadow System for 118-bus system - Bus 85 Voltage Magnitude MeasB85VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB86VOLTV', 3, NULL, 'SS118-MEASB86VOLTV', 'Shadow System for 118-bus system - Bus 86 Voltage Magnitude MeasB86VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB87VOLTV', 3, NULL, 'SS118-MEASB87VOLTV', 'Shadow System for 118-bus system - Bus 87 Voltage Magnitude MeasB87VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB88VOLTV', 3, NULL, 'SS118-MEASB88VOLTV', 'Shadow System for 118-bus system - Bus 88 Voltage Magnitude MeasB88VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB89VOLTV', 3, NULL, 'SS118-MEASB89VOLTV', 'Shadow System for 118-bus system - Bus 89 Voltage Magnitude MeasB89VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB90VOLTV', 3, NULL, 'SS118-MEASB90VOLTV', 'Shadow System for 118-bus system - Bus 90 Voltage Magnitude MeasB90VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB91VOLTV', 3, NULL, 'SS118-MEASB91VOLTV', 'Shadow System for 118-bus system - Bus 91 Voltage Magnitude MeasB91VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB92VOLTV', 3, NULL, 'SS118-MEASB92VOLTV', 'Shadow System for 118-bus system - Bus 92 Voltage Magnitude MeasB92VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB93VOLTV', 3, NULL, 'SS118-MEASB93VOLTV', 'Shadow System for 118-bus system - Bus 93 Voltage Magnitude MeasB93VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB94VOLTV', 3, NULL, 'SS118-MEASB94VOLTV', 'Shadow System for 118-bus system - Bus 94 Voltage Magnitude MeasB94VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB95VOLTV', 3, NULL, 'SS118-MEASB95VOLTV', 'Shadow System for 118-bus system - Bus 95 Voltage Magnitude MeasB95VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB96VOLTV', 3, NULL, 'SS118-MEASB96VOLTV', 'Shadow System for 118-bus system - Bus 96 Voltage Magnitude MeasB96VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB97VOLTV', 3, NULL, 'SS118-MEASB97VOLTV', 'Shadow System for 118-bus system - Bus 97 Voltage Magnitude MeasB97VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB98VOLTV', 3, NULL, 'SS118-MEASB98VOLTV', 'Shadow System for 118-bus system - Bus 98 Voltage Magnitude MeasB98VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB99VOLTV', 3, NULL, 'SS118-MEASB99VOLTV', 'Shadow System for 118-bus system - Bus 99 Voltage Magnitude MeasB99VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB100VOLTV', 3, NULL, 'SS118-MEASB100VOLTV', 'Shadow System for 118-bus system - Bus 100 Voltage Magnitude MeasB100VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB101VOLTV', 3, NULL, 'SS118-MEASB101VOLTV', 'Shadow System for 118-bus system - Bus 101 Voltage Magnitude MeasB101VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB102VOLTV', 3, NULL, 'SS118-MEASB102VOLTV', 'Shadow System for 118-bus system - Bus 102 Voltage Magnitude MeasB102VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB103VOLTV', 3, NULL, 'SS118-MEASB103VOLTV', 'Shadow System for 118-bus system - Bus 103 Voltage Magnitude MeasB103VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB104VOLTV', 3, NULL, 'SS118-MEASB104VOLTV', 'Shadow System for 118-bus system - Bus 104 Voltage Magnitude MeasB104VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB105VOLTV', 3, NULL, 'SS118-MEASB105VOLTV', 'Shadow System for 118-bus system - Bus 105 Voltage Magnitude MeasB105VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB106VOLTV', 3, NULL, 'SS118-MEASB106VOLTV', 'Shadow System for 118-bus system - Bus 106 Voltage Magnitude MeasB106VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB107VOLTV', 3, NULL, 'SS118-MEASB107VOLTV', 'Shadow System for 118-bus system - Bus 107 Voltage Magnitude MeasB107VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB108VOLTV', 3, NULL, 'SS118-MEASB108VOLTV', 'Shadow System for 118-bus system - Bus 108 Voltage Magnitude MeasB108VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB109VOLTV', 3, NULL, 'SS118-MEASB109VOLTV', 'Shadow System for 118-bus system - Bus 109 Voltage Magnitude MeasB109VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB110VOLTV', 3, NULL, 'SS118-MEASB110VOLTV', 'Shadow System for 118-bus system - Bus 110 Voltage Magnitude MeasB110VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB111VOLTV', 3, NULL, 'SS118-MEASB111VOLTV', 'Shadow System for 118-bus system - Bus 111 Voltage Magnitude MeasB111VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB112VOLTV', 3, NULL, 'SS118-MEASB112VOLTV', 'Shadow System for 118-bus system - Bus 112 Voltage Magnitude MeasB112VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB113VOLTV', 3, NULL, 'SS118-MEASB113VOLTV', 'Shadow System for 118-bus system - Bus 113 Voltage Magnitude MeasB113VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB114VOLTV', 3, NULL, 'SS118-MEASB114VOLTV', 'Shadow System for 118-bus system - Bus 114 Voltage Magnitude MeasB114VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB115VOLTV', 3, NULL, 'SS118-MEASB115VOLTV', 'Shadow System for 118-bus system - Bus 115 Voltage Magnitude MeasB115VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB116VOLTV', 3, NULL, 'SS118-MEASB116VOLTV', 'Shadow System for 118-bus system - Bus 116 Voltage Magnitude MeasB116VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB117VOLTV', 3, NULL, 'SS118-MEASB117VOLTV', 'Shadow System for 118-bus system - Bus 117 Voltage Magnitude MeasB117VoltV', 1);
INSERT INTO Measurement(HistorianID, DeviceID, PointTag, SignalTypeID, PhasorSourceIndex, SignalReference, Description, Enabled) VALUES(1, 1, 'SS_118:MEASB118VOLTV', 3, NULL, 'SS118-MEASB118VOLTV', 'Shadow System for 118-bus system - Bus 118 Voltage Magnitude MeasB118VoltV', 1);

```