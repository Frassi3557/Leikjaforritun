# Verkefni 4

## Útskýrðu muninn á 2d og 3d leikjagerð í Unity?
í 2D leikjagerð eru notuð svokölluð sprites, fletir sem eru bara á x og y-ás, ef þú myndir snúa honum um y-ásinn um 90° myndi hann ekki lengur sjást. Í flestum tilfellum er myndavél bara með eitt, orthographic, sjónarhorn. Sprites eru samt sem áður oft staðsett einhversstaðar á z-ás í leiknum, en alltaf eru þau 0 á dýpt í y-ásnum, þ.e sprite-ið sjálft.

Í 3D leikjagerð er unnið með form sem eru á x,y og z-ás. Í 3D leikjagerð er almennt unnið með cubemaps, shaders o.s.frv.. 3D leikir eru því flóknari á tæknilegu stigi, en er ferlið á bak við forritun í 2D og 3D ekki svo ólíkt.


## Berðu saman og tilgreindu amk. 3 mismunandi tegundir af 2d tölvuleikjum
Dæmi um fræga 2D leiki:

Action: Hotline Miami, Hyperlight Drifter, Enter the Gungeon, Cuphead.
Aðal áherslan er á hasar og við fyrstu sýn er ekki mikil baksaga eða "world building". Hotline Miami og Hyperlight Drifter hinsvegar eru kjaftfullir af sögu þegar að nánar er litið.

Strategy: Rimworld, The Escapists, Prison Architect, Factorio.
Aðal áherslan er í bragðvísi eða herkænsku. Í Rimworld þarftu að stjórna nýlendu á ókunnugri plánetu og lifa af. Prison Architect snýst um að hanna hið fullkomna fangelsi, The Escapists snýst hinsvegar um að brjótast úr því. Factorio snýst um mann sem er dæmdur í útleigð á ókunnuga plánetu, spilari þarf að búa til eins góða verksmiðju og hann getur, til þess að búa til geimflaug og komast af plánetunni.

Adventure: Starbound, Undertale, Terraria.
Aðal áhersla er á atmosphere, oft er tónlist helsta áherslan og oft mjög stílíseraðir leikir. Flottir bakgrunnir og framandi staðsetningar, "other worldly" óvinir.

Puzzle: Papers, Please; Tetris.
Aðal áherslan er að leysa gátur eða þrautir. Papers, Please setur spilara í hlutverk landamæraeftirlits í Sóvét Ríkjunum. Spilari þarf að taka við vegabréfum frá fólki og staðfesta að allt sé eins og það eigi að vera. Það þekkja allir Tetris, það er mest seldi leikur allra tíma, hann er svolítið eins og dynamic púsluspil sem endar aldrei.


## Hvað er og hvenær er heppilegt að nota 2.5d í tölvuleikjagerð? 
2.5D er vídd eða sjónarhorn er í raun 2D sem lítur út fyrir að vera 3D.
Mjög algengt í eldri leikjum eins og svo sem: Age of Empires, Civilization 3, SimCity 2000, Diablo o.s.frv... 
Á þeim tíma, þ.e. á 10. áratuginum þurfti fólk að vera ansi hugmyndaríkt þar sem tölvurnar á þeim tíma voru ekki nógu kraftmiklar til að keyra 3D leiki af einhverju viti. Einnig var mjög takmarkað pláss á floppy drifum.
Leikir eins og DooM og Wolfenstein notuðu líka svipaða aðferð til þess að nota 2D sem leit út fyrir að vera 3D, með aðferð sem heitir raycasting.


## Hvers vegna að nota 4d í tölvuleikjagerð? Komdu með dæmi um tölvuleiki í 4d og útskýrðu 4d virkni hans
Það fer eftir því hvað þú telur fjórðu víddina vera, margir telja hana vera tíminn og eru til þó nokkrir leikir sem nýta tímaflakk sem tæki til að segja sögu leiksins. Eitt dæmi úr leik sem ég hef spilað er í Dishonored 2, þar fær spilari tæki í hendurnar sem gerir honum kleift að ferðast aftur í tímann. Spilari er í yfirgefnu húsi þar sem flestar gönguleiðir eru girtar af, þar sem húsið er gamalt og liggur í rústum. Spilarinn getur þá ferðast aftur í tímann, þegar að húsið var nýtt og komist þannig í gegnum rústirnar og jafnvel fært hluti til, og búið þannig til nýja leið, í nútímanum. 
Dæmi: https://www.youtube.com/watch?v=fGy6vsA7Z9M

Titanfall 2 gerði einnig svipað: https://youtu.be/MOLS8vt9AaM?t=39

Miegakure er frægasti 4D leikurinn og nýtir hann fjórðu víddina sem raunverulega fleti, hægt er að breyta umhverfinu og snýst leikurinn um að leysa "puzzles" með þessari fjórðu vídd.
Dæmi: https://www.youtube.com/watch?v=9EfiilXN6S8

4D getur verið mjög áhrifaríkt tól til þess að segja sögu og tel ég það vera helsta ástæðan til að nota hana í tölvuleik.
