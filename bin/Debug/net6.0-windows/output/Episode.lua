LuaR  

            %   e@  ฅ   @@ @   @ภ@     ภ  A @  @        Episode_Init    Callback_OnLogicReady    Add    IsToolBuild    Callback_OnGameSceneOpen                @ A@    มภ  @  @ A  @ ม @  @ Aภ   ม@ @  @ A ภ ม  @  @ A@  มภ @         Inventory_InitItem    Inventory - Bandages    ui_icon_bandages.d3dtx 	   Bandages    Inventory - Necklace    ui_icon_necklace.d3dtx    Talia's Necklace    Inventory - Poultice    ui_icon_herbalPoultice.d3dtx    Herbal Poultice    Inventory - Strange Key    ui_icon_key.d3dtx    Strange Key    Inventory - Tyrell Seal    ui_icon_seal.d3dtx    Tyrell Family Seal          Q   @file:///c:/telltale/projects/gameofthrones/gameofthrones102/scripts/episode.lua                                                                                            _ENV #   (       F @ @  ม     ร ]@        AgentCreate    Dev    speaker          Q   @file:///c:/telltale/projects/gameofthrones/gameofthrones102/scripts/episode.lua    &   &   &   &   &   &   &   (         scene              _ENV 0        ๋    @ A@  @  ม  @  @ A@  ภ  ม  A @ @ A@   มภ  @ @ A@  @ ม  Aม @  @ A@    ม@  @ @ A@  ภ ม  A @ @ A@   มภ  @ @ A@  @ ม  Aม @  @ A@    ม@  @ @ Aภ  @  มภ @  @ Aภ  ภ  ม  A AA @  @ Aภ   ม ม AA @  @ Aภ  @ ม  A AA @  @ Aภ    ม  AA @  @ Aภ  ภ มภ  A	 @  @ Aภ   ม@	 	 AA @  @ Aภ  @ มภ	 
 AA @  @ Aภ    ม@
 
 AA @  @ Aภ  ภ
 ม  A AA @  @ A @  ม @  @ A ภ  มภ ม A @  @ A  ม@  A @  @ A @ มภ  A @  @ A   ม@  A @  @ A ภ มภ  A @  @ A  ม@  @ภN A  @ @ภN A ภ @ภN A  @ @ภN A ภ @ภN A  ภ  ัข าฃาค@ภN Aภ   @ภN A@  @ภN Aภ ภ  @TจภTฉ@Uช@ภN A    ึซึฌ@ภN Aภ   @ภN A@  @ภN Aภ   @ภN A@ ภ  ภXฑ@YฒภYณ@ Z @   i      DebugMenu_AddButton   ?   Act 1    @   Previously On    PreviouslyOn   @@   Yunkai Tavern    YunkaiTavern   @   Yunkai Tavern Fight &   LogicSet( "1 - Killed Tazal", true );    @   Opening Credits    OpeningCredits   ภ@   Forrester Courtyard    ForresterCourtyard   เ@   Forrester Lords Chamber    ForresterLordsChamber    A    Forrester Lords Chamber - Talia !   LogicSet( "1 - Woke Up", true );   A   Castle Black Courtyard    CastleBlackCourtyard    Act 2    Forrester Courtyard - Gauntlet    LogicSet( kAct, 2 );    Forrester Great Hall    ForresterGreatHall    Kings Landing Margaery's Room    KingsLandingMargaeryRoom #   Castle Black Courtyard - Free Walk    Castle Black Courtyard - Fight <   LogicSet( kAct, 2 ); LogicSet( "2 - Got Black Eye", true );    Kings Landing Gardens    KingsLandingGardens    Kings Landing Throne Room    KingsLandingThroneRoom    Yunkai Alleys    YunkaiAlleys    A   Kings Landing Mira's Room    KingsLandingMiraRoom    Act 3    Forrester Great Hall - Elaena    LogicSet( kAct, 3 );    Castle Black Wall    CastleBlackWall    Castle Black Wall - Top ?   LogicSet( kAct, 3 ); LogicSet( "3 - Reached Wall Top", true );    Kings Landing Gardens Night    KingsLandingGardensNight    Forrester Grove    ForresterGrove    Next Time On    NextTimeOn    PersistentLogic_AddKey $   Episode 101 - Killed Bolton Soldier %   153205E2-7BC1-4AAF-BAE9-2A378CB34FE6    Episode 101 - Accepted Exile L   A277B6D8-C67F-446A-9885-D5690407AF67 | 8C5B9839-E01B-4060-BC77-50084089A073    Episode 101 - Took Bandages %   FC47629A-D2CA-42DE-B97C-B82C178A7611    Episode 101 - Took Poultice %   007300B5-45F8-456E-A364-63BFEDA8144E    Episode 101 - Whitehill Choice    Craven %   BF552625-0D04-401B-816E-3829D78D71C0    Like %   0D4FC150-A72B-4A9E-BEC8-EEE43ED57083    Right %   0689525B-453D-4FD0-B68B-CFE8DB5CF1EC #   Episode 101 - Accepted Tyrion Deal %   46646FE1-C011-4BE7-847C-C5117DEFB285 #   Episode 101 - Asked Marge for Help %   C21FCE1A-4D86-4B31-9D7A-720C8977F306    Episode 101 - Erik Choice    Feed %   91FCC715-087A-44F9-B61E-E93E43B98377    Fingers %   96EF2BF9-4B92-4CD3-9FA2-6BDEA148B711    Wall %   89307CB7-5517-4D61-8062-56927EF0B982    Episode 101 - Sentinal Choice    Duncan %   C652CE80-CF45-4940-82B3-1B040F7BD21C    Royland %   794C0B7C-FF1C-4E6F-A5E1-05F38137E0B8 #   Episode 101 - Sent Malcom to Essos %   9913F76E-93B3-402C-8CCD-6EF9E718EDA9     Episode 101 - Stole Strange Key %   E6010B1A-5CA3-473C-9E22-598A3593455B     Episode 101 - Stole Tyrell Seal %   C72EA796-8A23-4C25-97A4-7A3A996285D5    Episode 101 - Ramsay Choice    Grab %   820DF6F5-DCB1-4C83-AAAF-4B8773852DFA    Demand %   F7C6929D-70C2-499A-B29B-D1480F289004    Hostage %   6FDD6ED3-CB44-4750-B12A-F9E7895405AF     PersistentLogic_UpdateGameLogic          Q   @file:///c:/telltale/projects/gameofthrones/gameofthrones102/scripts/episode.lua ๋   3   3   3   3   3   4   4   4   4   4   4   5   5   5   5   5   5   6   6   6   6   6   6   6   7   7   7   7   7   7   8   8   8   8   8   8   9   9   9   9   9   9   :   :   :   :   :   :   :   ;   ;   ;   ;   ;   ;   =   =   =   =   =   >   >   >   >   >   >   >   ?   ?   ?   ?   ?   ?   ?   @   @   @   @   @   @   @   A   A   A   A   A   A   A   B   B   B   B   B   B   B   C   C   C   C   C   C   C   D   D   D   D   D   D   D   E   E   E   E   E   E   E   F   F   F   F   F   F   F   H   H   H   H   H   I   I   I   I   I   I   I   J   J   J   J   J   J   J   K   K   K   K   K   K   K   L   L   L   L   L   L   L   M   M   M   M   M   M   M   N   N   N   N   N   N   R   R   R   R   U   U   U   U   X   X   X   X   [   [   [   [   ^   ^   ^   ^   ^   ^   ^   d   d   d   d   g   g   g   g   m   m   m   m   m   m   m   p   p   p   p   p   p   s   s   s   s   v   v   v   v   y   y   y   y   |   |   |   |   |   |   |   ~   ~                _ENV     Q   @file:///c:/telltale/projects/gameofthrones/gameofthrones102/scripts/episode.lua       (      0                                                OnLogicReady          OnGameSceneOpen             _ENV 