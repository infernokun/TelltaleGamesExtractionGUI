LuaR  

               A@    ÁÀ   Á   C    å  %C  e  @eÃ  @e @eC @e @eÃ @e @FÃB  À  ]C        CastleBlackCourtyard    adv_castleBlackCourtyard    Archery    cam_station_archery   ¿"   CastleBlackCourtyard_ArcheryBegin     CastleBlackCourtyard_ArcheryEnd    CastleBlackCourtyard_OnFire !   CastleBlackCourtyard_OnMouseDown    CastleBlackCourtyard_OnMouseUp !   CastleBlackCourtyard_OnMouseMove 
   SceneOpen 	   %   8     Q    @ E  @  F@    ÆÀ@  ] [    F@A    ÆA ÁA A ]@F@A    Æ@B ÁA A ]@F@A    ÆB ÁA A ]@F@A    ÆÀB ÁA A ]@F@A    Æ C ÁA A ]@F@A    Æ@C ÁA A ]@F@A    ÆC ÁA A ]@F@A    ÆÀC ÁA A ]@F@A    ÆÀC AD A ]@F@A    ÆÀD ÁA A ]@F@A    Æ E ÁA AA ]@FE    ]@         FileSetExtention    imap    CreateResource    kDirInputMaps    GameOfThrones102    InputMapperAddEvent    kEventCodeEnter    kEventBegin    CastleBlackCourtyard_OnFire    kEventCodeButtonA    kEventCodeButtonB    kEventCodeButtonX    kEventCodeButtonY    kEventCodeTriggerL    kEventCodeTriggerR    kEventCodeMouseL !   CastleBlackCourtyard_OnMouseDown 
   kEventEnd    CastleBlackCourtyard_OnMouseUp    kEventCodeMouseR    kEventCodeMouseMove !   CastleBlackCourtyard_OnMouseMove    Save          ^   @file:///c:/telltale/projects/gameofthrones/gameofthrones102/scripts/castleblackcourtyard.lua Q   (   (   (   (   )   )   )   )   )   )   )   *   *   *   *   *   *   +   +   +   +   +   +   ,   ,   ,   ,   ,   ,   -   -   -   -   -   -   .   .   .   .   .   .   /   /   /   /   /   /   0   0   0   0   0   0   1   1   1   1   1   1   2   2   2   2   2   2   3   3   3   3   3   3   4   4   4   4   4   4   5   5   5   8      	   fileName    Q         _ENV 
   kInputMap <   M           	      À      @  A  @ À  A  @Á Å   @  @ @Á ÁÀ Â @ @   	      Input_UseTouch    @4   adv_castleBlackCourtyard_garedCrossbowNoDrift.chore   @-   adv_castleBlackCourtyard_garedCrossbow.chore    AgentSetProperty    Pan Cam - Dampening    obj_garedArms 
   kIdleAnim        
  ^   @file:///c:/telltale/projects/gameofthrones/gameofthrones102/scripts/castleblackcourtyard.lua    >   >   A   C   C   C   C   D   E   E   G   H   J   J   J   J   J   K   K   K   K   K   M         camDampening       
   idleChore             mbTouching    _ENV    kArcheryCam U   z     R    @     @   @ @@ E   @@      À@ F A  @A ÀA FÀA ]       @B A À @@B A   @ÀÀ@ A@      C AÀ @  D  @  @D @ À@ F A  D À@ AÀ       E A@ @ À@ A       E AÀ @  E A  @ @F A À Á  @ @G C  @         IsToolBuild    Game_NewScene    Game_GetDebug 	   LogicGet    kAct    @   PropertyGet    GetPreferences    Skip Enter Cutscenes    Dialog_Run    env_castleBlackCourtyard_fw    logic_startScene    logic_freeWalk    2 - Got Black Eye    Game_SetSceneDialogNode    logic_jumpToFight    Game_GetLoaded    TitleCard_CharacterSwitch   ?   Episode 101 - Took Bandages    Inventory_AddItem    Inventory - Bandages    Episode 101 - Took Poultice    Inventory - Poultice    Inventory - Necklace    AgentSetProperty    ui_reticle_ringFrame    ui_reticle_expanded - Texture &   ui_reticle_expandedHighContrast.d3dtx    Game_StartScene           ^   @file:///c:/telltale/projects/gameofthrones/gameofthrones102/scripts/castleblackcourtyard.lua R   W   W   W   W   X   X   [   [   [   [   ]   ]   ]   ]   ]   ]   ]   ]   ]   ^   ^   ^   ^   ^   ^   ^   _   _   _   _   `   `   `   `   `   a   a   a   a   a   b   b   b   f   f   f   f   h   h   j   j   j   j   j   k   k   k   k   k   l   l   l   n   n   n   n   n   o   o   o   q   q   q   t   t   t   t   t   x   x   x   z             _ENV    CreateAssets    kScene    kScript ~        D    À A@   	   À E   ÀÀ Ã  @  À A   	  @Á E     @ F À  ]  À ÁÀ  Æ À  Ý À AA  FÀ  ] À ÁÁ  $@  	  Ã E  À FAÁ  Ã  ]A"  £@þ@Ã C   @ÀÃ     @   @  Ä C   @ @Ä E @ Ä E  @      
   AgentFind    trigger_dialog_targetCrow    AgentSetProperty    kTriggerEnabled    obj_crossbowRay 
   AgentHide    obj_dummyChestA    obj_dummyChestB    obj_dummyChestC    obj_dummyHeadA    obj_dummyHeadB    obj_dummyHeadC    ipairs    Callback_OnSetInputMode    Add    Input_UseTouch    Reticle_EnableSelection    Station_Enter    InputMapperActivate          ^   @file:///c:/telltale/projects/gameofthrones/gameofthrones102/scripts/castleblackcourtyard.lua D                                                                                                                                                                                                                     (for generator) )   0      (for state) )   0      (for control) )   0      _ *   .      target *   .         mCrowTrigger    _ENV    mRay 	   mTargets    OnSetInputMode    kArcheryCam 
   kInputMap     ³     !    @ E  @ @@ @   @À@ C  @  A @ @A E  À FA  Ã ]A"  £@þA E    @   	    	    	          InputMapperDeactivate    Callback_OnSetInputMode    Remove    Reticle_EnableSelection    Station_Exit    ipairs 
   AgentHide          ^   @file:///c:/telltale/projects/gameofthrones/gameofthrones102/scripts/castleblackcourtyard.lua !   ¢   ¢   ¢   ¤   ¤   ¤   ¤   ¦   ¦   ¦   §   §   ©   ©   ©   ©   ª   ª   ª   ª   ©   ©   ­   ­   ­   ­   ¯   ¯   °   °   ±   ±   ³         (for generator)          (for state)          (for control)          _          target             _ENV 
   kInputMap    OnSetInputMode 	   mTargets    mRay    mCrowTrigger »   ã     	G    @  F@@ X@      @  E  @      @  	  À@ E      À  A A@ @   A AÀ   @   F B   ] ÀÁ@ Å    @   @ b  ã@ýF@B  ]@ FÀB  Á    ]@    ÀF@C C ÀCÆ D    Ý A A  Ã   ]@À F@C À Ã   ]@        Game_GetMode    eModeStation    GetFrameNumber    AgentCollide    Print $   Don't be trying to shoot the crows. 
   AgentHide    ui_crossbowReticle    ipairs    RenderDelay   ?   AgentSetProperty    Pan Cam - Enabled    Game_RunSceneDialog    string    gsub    AgentGetName    obj    use    cs_archeryMiss          ^   @file:///c:/telltale/projects/gameofthrones/gameofthrones102/scripts/castleblackcourtyard.lua G   ½   ½   ½   ½   ½   ¾   Á   Á   Á   Á   Á   Â   Å   Å   Å   Ç   Ç   Ç   Ç   Ç   Ç   È   È   È   É   Ì   Ì   Ì   Ì   Î   Ð   Ð   Ð   Ð   Ñ   Ñ   Ñ   Ñ   Ñ   Ñ   Ò   Ò   Ð   Ð   Ø   Ø   Ø   Û   Û   Û   Û   Û   Ý   Ý   Þ   Þ   Þ   Þ   Þ   Þ   Þ   Þ   Þ   Þ   Þ   Þ   à   à   à   à   ã      
   targetHit    G      (for generator) !   ,      (for state) !   ,      (for control) !   ,      _ "   *      target "   *         _ENV 
   mFrameNum    mRay    mCrowTrigger 	   mTargets    kArcheryCam ç   ñ         @     À@@  	    	     	 @ @ @         Input_UseTouch    CursorGetPos    CastleBlackCourtyard_OnFire          
	^   @file:///c:/telltale/projects/gameofthrones/gameofthrones102/scripts/castleblackcourtyard.lua    é   é   é   é   ê   ê   ê   ë   ë   ì   ì   ì   î   î   ñ             _ENV    mCursorPos    mbTouching    mbMoved õ   þ                 	     @  @  @@         CastleBlackCourtyard_OnFire        
	  ^   @file:///c:/telltale/projects/gameofthrones/gameofthrones102/scripts/castleblackcourtyard.lua    ÷   ÷   ÷   ø   ø   ù   ù   ù   ú   ú   þ             mbTouching    mbMoved    _ENV                   @  @ @E @@    Y    @    	          VectorDistance    CursorGetPos ÍÌL=       
	  ^   @file:///c:/telltale/projects/gameofthrones/gameofthrones102/scripts/castleblackcourtyard.lua                                                mbTouching    mbMoved    _ENV    mCursorPos     ^   @file:///c:/telltale/projects/gameofthrones/gameofthrones102/scripts/castleblackcourtyard.lua    
                           8   M   z   U      ~   ³       ã   »   ñ   ç   þ   õ                       kScript          kScene       
   kInputMap          kArcheryCam          mCrowTrigger          mRay       	   mTargets       
   mFrameNum          mCursorPos          mbMoved          mbTouching 	         CreateAssets 
         OnSetInputMode             _ENV 