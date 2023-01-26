namespace ru.yandex.taxi
{
	using Context = android.content.Context;
	using Intent = android.content.Intent;
	using Log = android.util.Log;
	using C2DMBaseReceiver = com.google.android.c2dm.C2DMBaseReceiver;
	using C2DMService = ru.yandex.taxi.c2dm.C2DMService;

	public class C2DMReceiver : C2DMBaseReceiver
	{
	  public const string C2DM_EMAIL = "alexkir@yandex-team.ru";

	  public C2DMReceiver() : base("alexkir@yandex-team.ru")
	  {
	  }

	  public override void onError(Context paramContext, string paramString)
	  {
		Log.e("C2DMReceiver", "Error in C2DM protocol: " + paramString);
	  }

	  public override void onMessage(Context paramContext, Intent paramIntent)
	  {
		// Byte code:
		//   0: ldc 'C2DMReceiver'
		//   2: ldc 'C2DM on message'
		//   4: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   7: pop
		//   8: aload_0
		//   9: ldc 'activity'
		//   11: invokevirtual getSystemService : (Ljava/lang/String;)Ljava/lang/Object;
		//   14: checkcast android/app/ActivityManager
		//   17: invokevirtual getRunningAppProcesses : ()Ljava/util/List;
		//   20: astore_3
		//   21: iconst_0
		//   22: istore #4
		//   24: iload #4
		//   26: aload_3
		//   27: invokeinterface size : ()I
		//   32: if_icmpge -> 1182
		//   35: aload_3
		//   36: iload #4
		//   38: invokeinterface get : (I)Ljava/lang/Object;
		//   43: checkcast android/app/ActivityManager$RunningAppProcessInfo
		//   46: astore #5
		//   48: aload #5
		//   50: getfield processName : Ljava/lang/String;
		//   53: aload_0
		//   54: invokevirtual getPackageName : ()Ljava/lang/String;
		//   57: invokevirtual equals : (Ljava/lang/Object;)Z
		//   60: ifeq -> 612
		//   63: aload #5
		//   65: getfield importance : I
		//   68: bipush #100
		//   70: if_icmpne -> 612
		//   73: ldc 'C2DMReceiver'
		//   75: new java/lang/StringBuilder
		//   78: dup
		//   79: invokespecial <init> : ()V
		//   82: ldc 'App running: '
		//   84: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   87: aload #5
		//   89: getfield importance : I
		//   92: invokevirtual append : (I)Ljava/lang/StringBuilder;
		//   95: invokevirtual toString : ()Ljava/lang/String;
		//   98: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   101: pop
		//   102: iconst_1
		//   103: istore #4
		//   105: iload #4
		//   107: ifne -> 611
		//   110: aload_0
		//   111: ldc 'vibrator'
		//   113: invokevirtual getSystemService : (Ljava/lang/String;)Ljava/lang/Object;
		//   116: checkcast android/os/Vibrator
		//   119: ldc2_w 500
		//   122: invokevirtual vibrate : (J)V
		//   125: aload_1
		//   126: invokevirtual getResources : ()Landroid/content/res/Resources;
		//   129: astore #6
		//   131: new java/text/SimpleDateFormat
		//   134: dup
		//   135: ldc 'HH:mm'
		//   137: invokespecial <init> : (Ljava/lang/String;)V
		//   140: astore #7
		//   142: aload #6
		//   144: ldc 2131296578
		//   146: iconst_1
		//   147: anewarray java/lang/Object
		//   150: dup
		//   151: iconst_0
		//   152: aload #7
		//   154: new java/util/Date
		//   157: dup
		//   158: invokespecial <init> : ()V
		//   161: invokevirtual format : (Ljava/util/Date;)Ljava/lang/String;
		//   164: aastore
		//   165: invokevirtual getString : (I[Ljava/lang/Object;)Ljava/lang/String;
		//   168: astore #8
		//   170: aload #6
		//   172: ldc 2131296273
		//   174: invokevirtual getString : (I)Ljava/lang/String;
		//   177: astore #9
		//   179: new android/content/Intent
		//   182: dup
		//   183: aload_1
		//   184: ldc ru/yandex/taxi/activity/StartActivity
		//   186: invokespecial <init> : (Landroid/content/Context;Ljava/lang/Class;)V
		//   189: astore #5
		//   191: aload_2
		//   192: invokevirtual getExtras : ()Landroid/os/Bundle;
		//   195: astore #10
		//   197: getstatic ru/yandex/taxi/client/TaxiClient.DATE_FORMAT : Ljava/text/SimpleDateFormat;
		//   200: aload #10
		//   202: ldc 'due'
		//   204: invokevirtual getString : (Ljava/lang/String;)Ljava/lang/String;
		//   207: invokevirtual parse : (Ljava/lang/String;)Ljava/util/Date;
		//   210: astore #11
		//   212: getstatic ru/yandex/taxi/client/TaxiClient.DATE_FORMAT : Ljava/text/SimpleDateFormat;
		//   215: aload #10
		//   217: ldc 'updated'
		//   219: invokevirtual getString : (Ljava/lang/String;)Ljava/lang/String;
		//   222: invokevirtual parse : (Ljava/lang/String;)Ljava/util/Date;
		//   225: astore #12
		//   227: aload #10
		//   229: ldc 'status'
		//   231: invokevirtual getString : (Ljava/lang/String;)Ljava/lang/String;
		//   234: astore #13
		//   236: aload #10
		//   238: ldc 'order_id'
		//   240: invokevirtual getString : (Ljava/lang/String;)Ljava/lang/String;
		//   243: astore_3
		//   244: aload #9
		//   246: astore #14
		//   248: new java/lang/StringBuilder
		//   251: astore_2
		//   252: aload #9
		//   254: astore #14
		//   256: aload_2
		//   257: invokespecial <init> : ()V
		//   260: aload #9
		//   262: astore #14
		//   264: ldc 'C2DMReceiver'
		//   266: aload_2
		//   267: ldc 'C2DM status: '
		//   269: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   272: aload #13
		//   274: invokevirtual append : (Ljava/lang/String;)Ljava/lang/StringBuilder;
		//   277: invokevirtual toString : ()Ljava/lang/String;
		//   280: invokestatic d : (Ljava/lang/String;Ljava/lang/String;)I
		//   283: pop
		//   284: aload #9
		//   286: astore #14
		//   288: aload #6
		//   290: ldc 2131296579
		//   292: invokevirtual getString : (I)Ljava/lang/String;
		//   295: astore #15
		//   297: aload #9
		//   299: astore #14
		//   301: aload_0
		//   302: invokevirtual getResources : ()Landroid/content/res/Resources;
		//   305: astore #16
		//   307: aload #9
		//   309: astore #14
		//   311: aload #16
		//   313: ldc 2131296398
		//   315: invokevirtual getString : (I)Ljava/lang/String;
		//   318: astore_2
		//   319: aload #9
		//   321: astore #14
		//   323: aload #16
		//   325: ldc 2131296399
		//   327: invokevirtual getString : (I)Ljava/lang/String;
		//   330: astore #17
		//   332: aload #9
		//   334: astore #14
		//   336: aload #16
		//   338: ldc 2131296400
		//   340: invokevirtual getString : (I)Ljava/lang/String;
		//   343: astore #16
		//   345: aload #9
		//   347: astore #14
		//   349: new java/util/Date
		//   352: astore #18
		//   354: aload #9
		//   356: astore #14
		//   358: aload #18
		//   360: invokespecial <init> : ()V
		//   363: aload #9
		//   365: astore #14
		//   367: aload #18
		//   369: invokevirtual getDate : ()I
		//   372: aload #11
		//   374: invokevirtual getDate : ()I
		//   377: if_icmpne -> 618
		//   380: aload #16
		//   382: astore_2
		//   383: aload #9
		//   385: astore #14
		//   387: new java/text/SimpleDateFormat
		//   390: astore #17
		//   392: aload #9
		//   394: astore #14
		//   396: aload #17
		//   398: aload_2
		//   399: invokestatic getCurrentLocale : ()Ljava/util/Locale;
		//   402: invokespecial <init> : (Ljava/lang/String;Ljava/util/Locale;)V
		//   405: aload #9
		//   407: astore #14
		//   409: aload #15
		//   411: iconst_1
		//   412: anewarray java/lang/Object
		//   415: dup
		//   416: iconst_0
		//   417: aload #17
		//   419: aload #11
		//   421: invokevirtual format : (Ljava/util/Date;)Ljava/lang/String;
		//   424: aastore
		//   425: invokestatic format : (Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;
		//   428: astore #9
		//   430: aload #9
		//   432: astore #14
		//   434: ldc 'driving'
		//   436: aload #13
		//   438: invokevirtual equals : (Ljava/lang/Object;)Z
		//   441: ifeq -> 646
		//   444: aload #9
		//   446: astore #14
		//   448: new android/content/Intent
		//   451: astore_2
		//   452: aload #9
		//   454: astore #14
		//   456: aload_2
		//   457: aload_0
		//   458: invokevirtual getApplicationContext : ()Landroid/content/Context;
		//   461: ldc ru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity
		//   463: invokespecial <init> : (Landroid/content/Context;Ljava/lang/Class;)V
		//   466: aload_2
		//   467: ldc 'when'
		//   469: aload #11
		//   471: invokevirtual putExtra : (Ljava/lang/String;Ljava/io/Serializable;)Landroid/content/Intent;
		//   474: pop
		//   475: aload_2
		//   476: ldc 'order id'
		//   478: aload_3
		//   479: invokevirtual putExtra : (Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;
		//   482: pop
		//   483: aload_2
		//   484: ldc 'demo'
		//   486: iconst_0
		//   487: invokevirtual putExtra : (Ljava/lang/String;Z)Landroid/content/Intent;
		//   490: pop
		//   491: ldc 2131296580
		//   493: istore #4
		//   495: aload #6
		//   497: iload #4
		//   499: invokevirtual getString : (I)Ljava/lang/String;
		//   502: iconst_1
		//   503: anewarray java/lang/Object
		//   506: dup
		//   507: iconst_0
		//   508: aload #7
		//   510: aload #12
		//   512: invokevirtual format : (Ljava/util/Date;)Ljava/lang/String;
		//   515: aastore
		//   516: invokestatic format : (Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;
		//   519: astore #5
		//   521: aload_2
		//   522: astore #14
		//   524: aload_3
		//   525: astore #17
		//   527: aload #5
		//   529: astore_2
		//   530: aload #9
		//   532: astore_3
		//   533: aload #17
		//   535: astore #9
		//   537: aload_0
		//   538: ldc 'notification'
		//   540: invokevirtual getSystemService : (Ljava/lang/String;)Ljava/lang/Object;
		//   543: checkcast android/app/NotificationManager
		//   546: astore #5
		//   548: aload #14
		//   550: ldc 'notification call'
		//   552: iconst_1
		//   553: invokevirtual putExtra : (Ljava/lang/String;Z)Landroid/content/Intent;
		//   556: pop
		//   557: aload_1
		//   558: iconst_0
		//   559: aload #14
		//   561: ldc 134217728
		//   563: invokestatic getActivity : (Landroid/content/Context;ILandroid/content/Intent;I)Landroid/app/PendingIntent;
		//   566: astore #14
		//   568: new android/app/Notification
		//   571: dup
		//   572: ldc 2130837647
		//   574: aload_2
		//   575: invokestatic currentTimeMillis : ()J
		//   578: invokespecial <init> : (ILjava/lang/CharSequence;J)V
		//   581: astore_1
		//   582: aload_1
		//   583: aload_0
		//   584: invokevirtual getApplicationContext : ()Landroid/content/Context;
		//   587: aload_3
		//   588: aload_2
		//   589: aload #14
		//   591: invokevirtual setLatestEventInfo : (Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Landroid/app/PendingIntent;)V
		//   594: aload_1
		//   595: bipush #16
		//   597: putfield flags : I
		//   600: aload #5
		//   602: aload #9
		//   604: invokevirtual hashCode : ()I
		//   607: aload_1
		//   608: invokevirtual notify : (ILandroid/app/Notification;)V
		//   611: return
		//   612: iinc #4, 1
		//   615: goto -> 24
		//   618: aload #9
		//   620: astore #14
		//   622: aload #18
		//   624: invokevirtual getDate : ()I
		//   627: iconst_1
		//   628: iadd
		//   629: aload #11
		//   631: invokevirtual getDate : ()I
		//   634: if_icmpne -> 643
		//   637: aload #17
		//   639: astore_2
		//   640: goto -> 383
		//   643: goto -> 383
		//   646: aload #9
		//   648: astore #14
		//   650: ldc 'waiting'
		//   652: aload #13
		//   654: invokevirtual equals : (Ljava/lang/Object;)Z
		//   657: ifeq -> 720
		//   660: aload #9
		//   662: astore #14
		//   664: new android/content/Intent
		//   667: dup
		//   668: aload_0
		//   669: invokevirtual getApplicationContext : ()Landroid/content/Context;
		//   672: ldc ru/yandex/taxi/activity/TaxiOnTheWayToSourceActivity
		//   674: invokespecial <init> : (Landroid/content/Context;Ljava/lang/Class;)V
		//   677: astore_2
		//   678: aload_2
		//   679: ldc_w 'arrived'
		//   682: iconst_1
		//   683: invokevirtual putExtra : (Ljava/lang/String;Z)Landroid/content/Intent;
		//   686: pop
		//   687: aload_2
		//   688: ldc 'when'
		//   690: aload #11
		//   692: invokevirtual putExtra : (Ljava/lang/String;Ljava/io/Serializable;)Landroid/content/Intent;
		//   695: pop
		//   696: aload_2
		//   697: ldc 'order id'
		//   699: aload_3
		//   700: invokevirtual putExtra : (Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;
		//   703: pop
		//   704: aload_2
		//   705: ldc 'demo'
		//   707: iconst_0
		//   708: invokevirtual putExtra : (Ljava/lang/String;Z)Landroid/content/Intent;
		//   711: pop
		//   712: ldc_w 2131296581
		//   715: istore #4
		//   717: goto -> 495
		//   720: aload #9
		//   722: astore #14
		//   724: ldc_w 'transporting'
		//   727: aload #13
		//   729: invokevirtual equals : (Ljava/lang/Object;)Z
		//   732: ifeq -> 778
		//   735: aload #9
		//   737: astore #14
		//   739: new android/content/Intent
		//   742: dup
		//   743: aload_0
		//   744: invokevirtual getApplicationContext : ()Landroid/content/Context;
		//   747: ldc_w ru/yandex/taxi/activity/TaxiOnTheWayToDescActivity
		//   750: invokespecial <init> : (Landroid/content/Context;Ljava/lang/Class;)V
		//   753: astore_2
		//   754: aload_2
		//   755: ldc 'order id'
		//   757: aload_3
		//   758: invokevirtual putExtra : (Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;
		//   761: pop
		//   762: aload_2
		//   763: ldc 'demo'
		//   765: iconst_0
		//   766: invokevirtual putExtra : (Ljava/lang/String;Z)Landroid/content/Intent;
		//   769: pop
		//   770: ldc_w 2131296582
		//   773: istore #4
		//   775: goto -> 495
		//   778: aload #9
		//   780: astore #14
		//   782: ldc_w 'complete'
		//   785: aload #13
		//   787: invokevirtual equals : (Ljava/lang/Object;)Z
		//   790: ifeq -> 852
		//   793: aload #9
		//   795: astore #14
		//   797: new android/content/Intent
		//   800: dup
		//   801: aload_0
		//   802: invokevirtual getApplicationContext : ()Landroid/content/Context;
		//   805: ldc_w ru/yandex/taxi/activity/RateActivity
		//   808: invokespecial <init> : (Landroid/content/Context;Ljava/lang/Class;)V
		//   811: astore_2
		//   812: aload_2
		//   813: ldc 'order id'
		//   815: aload_3
		//   816: invokevirtual putExtra : (Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;
		//   819: pop
		//   820: aload_2
		//   821: ldc 'demo'
		//   823: iconst_0
		//   824: invokevirtual putExtra : (Ljava/lang/String;Z)Landroid/content/Intent;
		//   827: pop
		//   828: aload_2
		//   829: ldc_w 'park id'
		//   832: aload #10
		//   834: ldc_w 'park_id'
		//   837: invokevirtual getString : (Ljava/lang/String;)Ljava/lang/String;
		//   840: invokevirtual putExtra : (Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;
		//   843: pop
		//   844: ldc_w 2131296583
		//   847: istore #4
		//   849: goto -> 495
		//   852: aload #9
		//   854: astore #14
		//   856: ldc_w 'failed'
		//   859: aload #13
		//   861: invokevirtual equals : (Ljava/lang/Object;)Z
		//   864: ifeq -> 878
		//   867: aload #5
		//   869: astore_2
		//   870: ldc_w 2131296584
		//   873: istore #4
		//   875: goto -> 495
		//   878: aload #9
		//   880: astore #14
		//   882: ldc_w 'calibrate'
		//   885: aload #13
		//   887: invokevirtual equals : (Ljava/lang/Object;)Z
		//   890: ifne -> 908
		//   893: aload #9
		//   895: astore #14
		//   897: ldc_w 'expired'
		//   900: aload #13
		//   902: invokevirtual equals : (Ljava/lang/Object;)Z
		//   905: ifeq -> 1172
		//   908: aload #9
		//   910: astore #14
		//   912: new android/content/Intent
		//   915: dup
		//   916: aload_0
		//   917: invokevirtual getApplicationContext : ()Landroid/content/Context;
		//   920: ldc_w ru/yandex/taxi/activity/SearchTaxiActivity
		//   923: invokespecial <init> : (Landroid/content/Context;Ljava/lang/Class;)V
		//   926: astore_2
		//   927: ldc_w 'calibrate'
		//   930: aload #13
		//   932: invokevirtual equals : (Ljava/lang/Object;)Z
		//   935: ifeq -> 1034
		//   938: aload #10
		//   940: ldc_w 'calibrate'
		//   943: invokevirtual getString : (Ljava/lang/String;)Ljava/lang/String;
		//   946: astore #5
		//   948: ldc_w 'break'
		//   951: aload #5
		//   953: invokevirtual equals : (Ljava/lang/Object;)Z
		//   956: ifeq -> 1023
		//   959: ldc_w 2131296585
		//   962: istore #19
		//   964: iconst_1
		//   965: istore #4
		//   967: aload_2
		//   968: ldc_w 'calibrate value'
		//   971: aload #5
		//   973: invokevirtual putExtra : (Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;
		//   976: pop
		//   977: iload #4
		//   979: istore #20
		//   981: iload #19
		//   983: istore #4
		//   985: aload_2
		//   986: ldc 'when'
		//   988: aload #11
		//   990: invokevirtual putExtra : (Ljava/lang/String;Ljava/io/Serializable;)Landroid/content/Intent;
		//   993: pop
		//   994: aload_2
		//   995: ldc 'order id'
		//   997: aload_3
		//   998: invokevirtual putExtra : (Ljava/lang/String;Ljava/lang/String;)Landroid/content/Intent;
		//   1001: pop
		//   1002: aload_2
		//   1003: ldc 'demo'
		//   1005: iconst_0
		//   1006: invokevirtual putExtra : (Ljava/lang/String;Z)Landroid/content/Intent;
		//   1009: pop
		//   1010: aload_2
		//   1011: ldc_w 'state'
		//   1014: iload #20
		//   1016: invokevirtual putExtra : (Ljava/lang/String;I)Landroid/content/Intent;
		//   1019: pop
		//   1020: goto -> 495
		//   1023: ldc_w 2131296586
		//   1026: istore #19
		//   1028: iconst_0
		//   1029: istore #4
		//   1031: goto -> 967
		//   1034: ldc_w 2131296587
		//   1037: istore #4
		//   1039: iconst_2
		//   1040: istore #20
		//   1042: goto -> 985
		//   1045: astore_3
		//   1046: ldc_w ''
		//   1049: astore #17
		//   1051: aload #5
		//   1053: astore_2
		//   1054: aload_3
		//   1055: astore #5
		//   1057: aload #9
		//   1059: astore_3
		//   1060: ldc 'C2DMReceiver'
		//   1062: ldc_w 'Fail parse c2dm message'
		//   1065: aload #5
		//   1067: invokestatic e : (Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)I
		//   1070: pop
		//   1071: aload #8
		//   1073: astore #5
		//   1075: aload #17
		//   1077: astore #9
		//   1079: aload_2
		//   1080: astore #14
		//   1082: aload #5
		//   1084: astore_2
		//   1085: goto -> 537
		//   1088: astore #9
		//   1090: aload #5
		//   1092: astore_2
		//   1093: aload #9
		//   1095: astore #5
		//   1097: aload_3
		//   1098: astore #17
		//   1100: aload #14
		//   1102: astore_3
		//   1103: goto -> 1060
		//   1106: astore #5
		//   1108: aload_3
		//   1109: astore #17
		//   1111: aload #9
		//   1113: astore_3
		//   1114: goto -> 1060
		//   1117: astore #5
		//   1119: aload_3
		//   1120: astore #17
		//   1122: aload #9
		//   1124: astore_3
		//   1125: goto -> 1060
		//   1128: astore #5
		//   1130: aload_3
		//   1131: astore #17
		//   1133: aload #9
		//   1135: astore_3
		//   1136: goto -> 1060
		//   1139: astore #5
		//   1141: aload_3
		//   1142: astore #17
		//   1144: aload #9
		//   1146: astore_3
		//   1147: goto -> 1060
		//   1150: astore #5
		//   1152: aload_3
		//   1153: astore #17
		//   1155: aload #9
		//   1157: astore_3
		//   1158: goto -> 1060
		//   1161: astore #5
		//   1163: aload_3
		//   1164: astore #17
		//   1166: aload #9
		//   1168: astore_3
		//   1169: goto -> 1060
		//   1172: aload #5
		//   1174: astore_2
		//   1175: ldc 2131296578
		//   1177: istore #4
		//   1179: goto -> 495
		//   1182: iconst_0
		//   1183: istore #4
		//   1185: goto -> 105
		// Exception table:
		//   from	to	target	type
		//   191	244	1045	java/lang/Exception
		//   248	252	1088	java/lang/Exception
		//   256	260	1088	java/lang/Exception
		//   264	284	1088	java/lang/Exception
		//   288	297	1088	java/lang/Exception
		//   301	307	1088	java/lang/Exception
		//   311	319	1088	java/lang/Exception
		//   323	332	1088	java/lang/Exception
		//   336	345	1088	java/lang/Exception
		//   349	354	1088	java/lang/Exception
		//   358	363	1088	java/lang/Exception
		//   367	380	1088	java/lang/Exception
		//   387	392	1088	java/lang/Exception
		//   396	405	1088	java/lang/Exception
		//   409	430	1088	java/lang/Exception
		//   434	444	1088	java/lang/Exception
		//   448	452	1088	java/lang/Exception
		//   456	466	1088	java/lang/Exception
		//   466	491	1106	java/lang/Exception
		//   495	521	1161	java/lang/Exception
		//   622	637	1088	java/lang/Exception
		//   650	660	1088	java/lang/Exception
		//   664	678	1088	java/lang/Exception
		//   678	712	1117	java/lang/Exception
		//   724	735	1088	java/lang/Exception
		//   739	754	1088	java/lang/Exception
		//   754	770	1128	java/lang/Exception
		//   782	793	1088	java/lang/Exception
		//   797	812	1088	java/lang/Exception
		//   812	844	1139	java/lang/Exception
		//   856	867	1088	java/lang/Exception
		//   882	893	1088	java/lang/Exception
		//   897	908	1088	java/lang/Exception
		//   912	927	1088	java/lang/Exception
		//   927	959	1150	java/lang/Exception
		//   967	977	1150	java/lang/Exception
		//   985	1020	1150	java/lang/Exception
	  }

	  public override void onRegistered(Context paramContext, string paramString)
	  {
		Log.d("C2DMReceiver", "C2DM on registered: " + paramString);
		Intent intent = new Intent(paramContext, typeof(C2DMService));
		intent.setAction("send device token");
		intent.putExtra("device token", paramString);
		paramContext.startService(intent);
	  }

	  public override void onUnregistered(Context paramContext)
	  {
		Log.d("C2DMReceiver", "C2DM on unregistered");
	  }
	}


	/* Location:              C:\Temp\dex\YT1-dex2jar.jar!\ru\yandex\taxi\C2DMReceiver.class
	 * Java compiler version: 6 (50.0)
	 * JD-Core Version:       1.1.3
	 */
}