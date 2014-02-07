using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SpellingBee.Resources;
using Windows.Phone.Speech.Synthesis;
using System.Threading;
using System.Windows.Threading;
using System.Windows.Media.Imaging;
using Microsoft.Advertising.Mobile.UI;
using System.Diagnostics; 

namespace SpellingBee
{
    public partial class MainPage : PhoneApplicationPage
    {
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
                if (NavigationService.CanGoBack)
                    NavigationService.RemoveBackEntry();
            
        }
        // Constructor
        public MainPage()
        {
            InitializeComponent();
           
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
            stringCompleter();
            startGame();
            AdUnit.ErrorOccurred += AdUnit_ErrorOccurred;
   
        }
        void AdUnit_ErrorOccurred(object sender, Microsoft.Advertising.AdErrorEventArgs e)
        {
            Debug.WriteLine("Ad refreshed!");
            AdUnit.Height = 0;
            AdUnit.Visibility = System.Windows.Visibility.Collapsed;
        }
        public void stringCompleter(){
            String[] grade1 = new String[]{"ALL","AND","ARE","ATE","BAD","BAG","BAKE","BAND","BAT","BED","BEE","BELL","BEST","BIG","BIKE","BILL","BIT","BLACK","BLUE","BONE","BOX","BOY","BROWN","BUS","BUT","CAME","CAN","CAP","CAR","CAT","COME","CUB","CUT","DAD","DAY","DID","DIG","DIP","DO","DOWN","DRY","EAT","FEET","FILL","FIND","FIT","FIVE","FOG","FROG","FROM","FUN","FUNNY","GAME","GET","GIRL","GO","GREEN","HAD","HAND","HAS","HAVE","HEN","HER","HID","HILL","HIS","HIT","HOPE","HOT","HOW","HUG","INTO","JET","JOB","JUMP","KID","LAND","LET","LID","LIKE","LIP","LOG","LOT","MAKE","MAN","MAP","MAY","MEET","MEN","MOM","NEST","ONE","OVER","PART","PAY","PEN","PET","PIG","PIN","PLAN","PLAY","POP","RAG","RAN","RED","RIDE","RIP","ROSE","RUG","RULE","RUN","SAD","SAND","SAT","SAW","SAY","SEE","SHE","SIDE","SIT","SIX","SLEEP","SLIDE","SO","SOME","SPOT","STONE","STOP","SUN","TAG","TAP","TELL","TEST","THAN","THAT","THE","THEN","THEY","THIN","THIS","THREE","TIME","TIP","TO","TOP","TREE","TRY","TUB","TWO","WAS","WATER","WAY","WE","WHAT","WHEN","WIG","WILL","WIN","WITH","YOU","ZIP"};
            String[] grade2 = new String[]{"AFTER","AGAIN","AIR","ALSO","ALWAYS","ANIMAL","ANY","ASK","AWAY","BACK","BARN","BATH","BEEN","BEFORE","BEST","BETTER","BLEND","BOAT","BOTH","BRIGHT","BUY","CALL","CANNOT","CHILD","CLEAN","CLOCK","COLD","COULD","COUNT","DEEP","DEER","DISH","DOES","DRESS","DRIP","DRIVE","DROP","DRUM","EACH","EIGHT","END","EVEN","FAST","FED","FEED","FIGHT","FIRST","FOUND","GAVE","GIVE","GOAT","GOES","GOOD","GREAT","GRIN","HAPPY","HELP","HERE","HIGH","HIM","HOME","HOUSE","JUMP","JUST","KIND","KISS","LIGHT","LINE","LION","LIST","LOCK","LONG","LOOK","LOUD","MADE","MESS","MOST","MUCH","MUST","NEW","NIGHT","NINE","NOW","OFF","ONLY","OR","OUR","OUT","PATH","PLACE","PLUS","POOL","PUT","READ","REST","RIGHT","ROCK","SAID","SAYS","SEA","SEEM","SEND","SILLY","SING","SLID","SLIP","SNACK","SPEED","SONG","SOON","STILL","STONE","SUCH","TAKE","TELL","THEM","THERE","THESE","TON","TRAY","TRICK","TUNE","UPON","US","USE","VERY","WASH","WELL","WENT","WHERE","WHICH","WHO","WHY","WISH","WORK","WOULD","YARD","YEAR","YET","YOUR"};
            String[] grade3 = new String[]{"ABOUT", "ACROSS", "AFRAID", "AGE", "AGO", "ALMOST", "ALSO", "ANYONE", "ANYTHING", "BALLOON", "BASKET", "BEAN", "BEAR", "BEHIND", "BIRTHDAY", "BLIND", "BODY", "BORN", "BOXES", "BREAD", "BREAKFAST", "BRUSH", "BUILD", "BUSES", "BUTTER", "CARRIES", "CAUGHT", "CHANGE", "CHEESE", "CHERRY", "CIRCUS", "CLASSES", "CLEAR", "CLIMB", "CLOWN", "COMING", "CRAWL", "CRAZY", "CRIES", "DINNER", "DOCTOR",   "DOLLAR", "DONE", "DRIVING", "EARLY", "EASY", "EVERYONE", "EVERYTHING", "EYES", "FINISH", "FLIES", "FOIL", "FOOD", "FORGOT", "FRIDAY", "FRONT", "FUNNY", "GIFT", "GRINNED", "GUESS", "HALF", "HAPPEN", "HEARD", "HEART", "HEAVY", "HELLO", "HIMSELF", "HORSE", "HURT",  "KEPT", "KEY", "KNEE", "KNEW", "KNOW", "LAMB", "LAUGH", "LAW", "LEAVE", "LEFT", "LIFE", "LIFT", "LIVED", "LOSE", "LOVE", "MARK", "MATCH", "MEAL", "MEAT", "MEET", "MERRY", "MONDAY", "MORE", "MORNING", "MOUSE", "MOUTH", "MOVE", "NEAR", "NEVER", "NEWSPAPER", "NOISE", "NONE", "ONCE", "OTHER", "OUTSIDE", "OWN", "PAINT", "PARK", "PAST", "PENNY", "PICNIC", "PIECE", "POINT", "PRIZE", "PUSH", "QUEEN", "QUICKLY", "RAISED", "REALLY", "RIDING", "RIVER", "RODE", "ROLL", "ROSES", "RULE", "RUNNING", "SAIL", "SALE", "SATURDAY", "SCHOOL", "SCRATCH", "SCREAM", "SERVE", "SEW", "SHELF", "SHINY", "SHOPPING", "SHOULD", "SITTING", "SKINNED", "SKY", "SLEPT", "SMILING", "SOFT", "SOMEONE", "SOMETHING", "SPEAK", "SPREAD", "SPRING", "STAIRS", "STOPPED", "STRAIGHT", "STREET", "STRETCH", "STRING", "STRONG", "SUIT", "SUMMER", "SUNDAY", "TENTH", "THICK", "THREW", "THROW", "THURSDAY", "TINY", "TODAY", "TOGETHER", "TOOTH", "TOUCH", "TOWN", "TRIES", "TROUBLE", "TRUE", "TUESDAY", "TURN", "UNTIL", "USED", "VOICE", "WALK", "WARM", "WEDNESDAY", "WHOLE", "WINDOW", "WORE", "WRONG", "WROTE", "YOUNG"};
            String[] grade4 = new String[] { "AGAINST", "AGREE", "AIRPORT", "ALARM", "ALIVE", "ALL", "RIGHT", "ALLEY", "ALPHABET", "ALTHOUGH", "ALWAYS", "ANGRIEST", "ANGRY", "ANIMAL", "ANSWER", "ASLEEP", "ATTACK", "AUNT", "BANANA", "BATTLE", "BEAUTIFUL", "BEAUTY", "BECOME", "BEGGAR", "BELIEVE", "BELONG", "BETWEEN", "BLANKET", "BLOOD", "BOTTLE", "BOUGHT", "BOUNCE", "BREATH", "BRIDGE", "BROKE", "BROKEN", "BROUGHT", "BUBBLE", "BUILDING", "BUILT", "BUSY", "BUTTON", "BUYING", "CALF", "CAMERA", "CARDBOARD", "CARING", "CARRYING", "CATCH", "CERTAIN", "CHANCE", "CHARGE", "CHEER", "CHICKEN", "CHIEF", "CHOICE", "CHOOSE", "CHORE", "CHOSE", "CIRCLE", "CITIES", "CLOTHING", "COAST", "COIN", "COMB", "COMMON", "COPY", "CORNER", "COTTAGE", "COTTON", "COUCH", "COUGH", "COUPLE", "COUSIN", "COVER", "CRAYON", "CRIME", "CROOKED", "CROW", "CROWD", "CRUMB", "CURL", "DAIRY", "DAMAGE", "DANGER", "DAWN", "DEAF", "DEAR", "DEATH", "DECIDE", "DEGREE", "DELIVER", "DIRTY", "DISAPPEAR", "DISLIKE", "DIVIDE", "DOUBLE", "DOWNSTAIRS", "DRAIN", "DRAWER", "EARLIER", "EARN", "EARTH", "EASIER", "EIGHTY", "EITHER", "ELECTRIC", "ENGINE", "ENOUGH", "EVENING", "EXCEPT", "FAINT", "FALSE", "FAMOUS", "FEAR", "FEATHER", "FELT", "FEVER", "FEW", "FIFTH", "FIFTY", "FINAL", "FOLLOW", "FOREVER", "FORGIVE", "FORTY", "FOURTH", "FRIGHT", "FRUIT", "GAIN", "GARDEN", "GASOLINE", "FEAR", "GENTLE", "GIANT", "GLANCE", "GOLD", "GRANDFATHER", "GRANDMOTHER", "GROCERIES", "GROWN", "GUARD", "HANDSOME", "HAPPIEST", "HEALTH", "HEARD", "HIKING", "HOLIDAY", "HONEY", "HOSPITAL", "HOUR", "HOWEVER", "HOWL", "HUNDRED", "HUNGRY", "HURRY", "HUSBAND", "IMPORTANT", "INTEREST", "INVITE", "JACKET", "JAW", "JUDGE", "JUICE", "KINDNESS", "KITCHEN", "KNEEL", "KNIGHT", "LIBRARIES", "LIBRARY", "LISTEN", "LONELY", "LOYAL", "MACHINE", "MAILBOX", "MEANT", "MEDAL", "MIDDLE", "MIRROR", "MISTAKE", "MOMENT", "MONKEY", "MOVEMENT", "NEITHER", "NICKEL", "NINETY", "NINTH", "NO", "ONE", "NOBODY", "OBEYED", "ODD", "OFFICE", "OFTEN", "PAPER", "PARENT", "PASTE", "PATH", "PEACEFUL", "PENCIL", "PERFECT", "PICTURE", "PLANET", "PLAYGROUND", "PLEASING", "POLICE", "POWERFUL", "PROPER", "PUBLIC", "QUESTION", "QUIET", "QUILT", "QUIT", "QUITE", "REACH", "READY", "REASON", "REMEMBER", "RETURN", "RIDGE", "ROAST", "ROOF", "ROUGH", "ROUND", "RULER", "SAFE", "SAUCE", "SCRAP", "SEARCH", "SEASON", "SELF", "SEVENTH", "SEVENTY", "SHARP", "SHOUT", "SIGH", "SIGN", "SIMPLE", "SINCE", "SINK", "SIXTH", "SIXTY", "SLEEVE", "SMOOTH", "SNEEZE", "SOFTEN", "SPARE", "SPECIAL", "SQUIRREL", "STEAL", "STEEL", "STRANGE", "STUDIED", "STUDYING", "STYLE", "SUPPOSE", "TENNIS", "THIRTY", "THUMB", "TOOL", "TOWEL", "TUBE", "TUNA", "TWENTY", "TWICE", "UNCLE", "UNDERSTAND", "USEFUL", "USELESS", "VILLAGE", "VISIT", "WAIT", "WEATHER", "WEIGHT", "WHENEVER", "WHETHER", "WIFE", "WONDER", "WOOD", "WORLD", "WORRIED", "WRIST", "WORSE", "WRITTEN", "YOURSELF", "ZEBRA", "ZERO", "ZOO" };
            String[] grade5 = new String[] { "ACCEPT", "ACCIDENTALLY", "ACQUIRE", "AMBULANCE", "ANCIENT", "APPEARANCE", "APPOINTMENT", "ARITHMETIC", "AUDIENCE", "AUTUMN", "BEAUTIFULLY", "BELIEFS", "BLOWN", "BOUGH", "BOWS", "CALENDAR", "CANYON", "CAPABLE", "CAPACITY", "CAUTION", "CEILING", "CHAMPION", "CHOIR", "CLEANSE", "COMBINATION", "COMFORTABLE", "COMMUNITY", "COMPLAIN", "CONCENTRATION", "CONCERN", "CONNECTION", "CONSTITUTION", "CONTAGIOUS", "CONVERSATION", "COOPERATION", "CORRECT", "COUPON", "CREATIVE", "CREATURE", "CRISIS", "CULTURE", "CURIOUS", "DANGEROUS", "DECISION", "DEMONSTRATE", "DENOMINATOR", "DEPARTMENT", "DEPARTURE", "DEPTH", "DESCENDANT", "DISAGREEMENT", "DISASTROUS", "DISCUSSION", "DISTANCE", "DISTRIBUTED", "EARLIEST", "ECHOES", "EDITION", "EDUCATE", "ELECTRICITY", "ELEMENT", "ELEVATOR", "EMERGENCY", "EMPLOYER", "EMPTINESS", "ENCOURAGEMENT", "ENTIRE", "ENTRANCE", "ENVELOPE", "EQUATOR", "ESPECIALLY", "ESTABLISH", "EXAMPLE", "EXCELLENT", "EXCITEMENT", "EXERCISE", "EXPERIENCE", "EXTERIOR", "FAMILIAR",  "FIERCE", "FIREPROOF", "FOLLOWING", "FORGETTING", "FORGIVENESS", "FOSSIL", "FREIGHT", "FRIGHTEN", "FUEL", "FURTHER", "GALLON", "GAZE", "GESTURE", "GOVERNOR", "GRADUATION", "GRATEFUL", "GRIEF", "HALVES", "HAMBURGER", "HANGAR", "HANGER", "HAPPINESS", "HEADACHE", "HEROES", "HISTORY", "HORIZON", "HUNGER", "HYPHEN", "IGNORE", "IMAGINATION", "IMMEDIATE", "IMPORTANCE", "IMPROVEMENT", "INDEPENDENCE", "INGREDIENT", "INJURY", "INQUIRE", "INSTEAD", "INSTRUCTION", "INTERMISSION", "INTERVIEW", "INVISIBLE", "INVITATION", "INVOLVE", "JEALOUS", "JUNIOR", "KNOWLEDGE", "LAWYER", "LEAGUE", "LEGAL", "LIBERTY", "LIQUID", "LISTENING", "LOAVES", "LOCATION", "LUGGAGE", "MANAGER", "MANNER", "MANOR", "MARRIAGE", "MEANT", "MECHANIC", "MEDICINE", "MENTION", "MINUS", "MINUTE", "MISTAKEN", "MISUNDERSTAND", "MIXTURE", "MOURN", "MULTIPLE", "MUSCLE", "MUSEUM", "MUSICIAN", "MUTE", "MYTH", "NATIONALITY", "NEGATIVE", "NOISY", "NOTICEABLE", "NOVEL", "NUMERATOR", "OBTAIN", "OCCUR", "OFFICIAL", "OPERATE", "ORIGINAL", "OUTLINE", "PARTIAL", "PASSENGER", "PATIENT", "PENALTY", "PENGUIN", "PERCENT", "PERFORMANCE", "PERSONAL", "PERSUADE", "PHYSICAL", "PIANO", "PLUMBER", "POEM", "POET", "POLICY", "POLLUTE", "POLLUTION", "POSITIVE", "POTATOES", "PREDICT", "PREFER", "PRESSURE", "PREVENT", "PRINCIPAL", "PRIVATE", "PROJECT", "PUMPKINS", "PURCHASE", "PURSE", "QUOTE", "RADIUS", "RAPID", "RATIO", "REALIZE", "RECENTLY", "RECYCLE", "REDUCE", "REFERRED", "REGARDLESS", "REGULAR", "REHEARSE", "RELIEF", "RELIEVE", "REMARKABLE", "REMIND", "REMOTE", "REPLACEMENT", "REPLIED", "REPLY", "REQUIREMENT", "RESCUE", "RESIDENT", "RESOURCES", "RESPECTFUL", "REVIEW", "ROAM", "ROUTINE", "RURAL", "SAFETY", "SAILOR", "SALUTE", "SATISFY", "SCARCELY", "SCIENTIFIC", "SCISSORS", "SELECTION", "SENIOR", "SENTENCE", "SEPARATELY", "SERIOUS", "SESSION", "SHAMPOO", "SHELVES", "SHORTEN", "SILENT", "SIMPLY", "SKETCH",  "SOLAR", "SOUGHT", "SPAGHETTI", "SPONGE", "SQUAWK", "STORAGE", "STRAIN", "STRATEGY", "STRENGTH", "STRIVE", "STRUGGLE", "STUDIOS", "SUCCESS", "SUGGESTION", "SUPPORT", "SURROUNDED", "SWORD", "SYSTEM", "TELEPHONE", "TELEVISION", "TEMPERATURE", "THEME", "THEMSELVES", "THEREFORE", "THICKEN", "THOUSAND", "THREAT", "TOMATOES", "TROPHIES", "TUTOR", "UNBELIEVABLE", "UNDERNEATH", "UNITE", "VACUUM", "VAIN", "VARIETY", "VARY", "VAULT", "VEGETABLE", "VEIN", "VIOLENCE", "VISIBLE", "VISION", "WASTE", "WHOSE", "WRESTLE", "WRINKLE", "YIELD" };
            String[] grade6 = new String[] { "ABANDON", "ABBREVIATION", "ABSENCE", "ABSOLUTELY", "ABSORB", "ABUNDANT", "ACCESSIBLE", "ACCOMPANIED", "ACCOMPLISHMENT", "ACCURATE", "ACHIEVEMENT", "ACRES", "ADEQUATE", "ADJUSTABLE", "ADMIT", "ADMITTANCE", "ADVICE", "ADVISE", "ALTERNATE", "ALTERNATIVE", "AMUSEMENT", "ANALYSIS", "ANCESTOR", "ANNIVERSARY", "APPRECIATE", "ARTIFICIAL", "ASSISTANCE", "ASSOCIATION", "ATHLETE", "ATMOSPHERE", "ATTENDANCE", "AUTHORITY", "BACTERIA", "BAGEL", "BAGGAGE", "BENEFITED", "BENEFITING", "BICYCLE", "BISCUIT", "BIZARRE", "BOULEVARD", "BOUNDARY", "BOUQUET", "BRILLIANT", "BROCHURE", "BULLETIN", "BUREAU", "CAMPAIGN", "CANCELLATION", "CANDIDATE", "CAPABLE", "CAPITAL", "CAPITOL", "CATEGORY", "CELERY", "CEMETERY", "CHANGEABLE", "CHAPERONE", "CHARACTER", "CINNAMON", "CIVILIZE", "COMMERCIAL", "COMMITTED", "COMMITTEE", "COMMOTION", "COMPANION", "COMPETENT", "COMPETITION", "COMPLEMENT", "COMPLEX", "COMPLIMENT", "COMPRESSOR", "CONCENTRATE", "CONCENTRATION", "CONDUCTOR", "CONFETTI", "CONGRATULATIONS", "CONSEQUENTLY", "CONTROLLING", "CRINGE", "CULMINATE", "CULPRIT", "DECEIVE", "DELAYED", "DEMOCRACY", "DEODORANT", "DESCENDENT", "DESCRIPTION", "DIAMETER", "DIAMOND", "DISCOURAGE", "DISGRACEFUL", "DISMISSAL", "DISTINGUISHED", "DREADFUL", "ECONOMICS", "ECONOMY", "ELEMENTARY", "EMBARRASS", "EMOTION", "EMPHASIZE", "ENCIRCLE", "ENCLOSING", "ENCOUNTER", "ENDURANCE", "ENGINEER", "ENVIRONMENT", "EPISODE", "EROSION", "ERUPTION", "EVIDENT", "EXCHANGE", "EXECUTIVE", "EXHIBIT", "EXPENSIVE", "EXTINCT", "EXTINGUISH", "EXTRAORDINARY", "EXTREMELY", "FABRICATE", "FAILURE", "FASCINATING", "FATIGUE", "FLAGRANT", "FOREIGN", "FORFEIT", "FREQUENTLY", "FUNDAMENTAL", "GENUINE", "GHETTO", "GOSSIPING", "GRADUAL", "GRAFFITI", "GRAMMAR", "GRIEVANCE", "GUARANTEE", "HARASS", "HAVOC", "HEROIC", "HESITATE", "HORRIFY", "HOSPITAL", "HUMID", "HUMILITY", "HYGIENE", "IDENTICAL", "IDLE", "IDOL", "ILLEGAL", "ILLUSTRATION", "IMAGINARY", "IMMEDIATELY", "IMMOBILIZE", "IMPOSSIBILITY", "INCONVENIENT", "INCREDIBLE", "INDIVIDUAL", "INFAMOUS", "INFLUENCE", "INFORMANT", "INHABIT", "INHERIT", "INNOCENCE", "INNOCENT", "INSTRUCTOR", "INTELLIGENT", "INTERRUPTION", "INTRODUCTION", "INVOLVEMENT", "IRATE", "IRRESISTIBLE", "JEALOUSY", "JUVENILE", "KETTLE", "KNITTING", "LABORATORY", "LANGUAGE", "LEGIBLY", "LIQUIDATION", "MANAGEMENT", "MEDIA", "MILEAGE", "MINIATURE", "MISBEHAVED", "MORALE", "MORTGAGE", "MOVEMENT", "MURMUR", "MUSICIAN", "MYSTERIOUS", "NEGOTIATE", "NERVOUS", "NUISANCE", "NURTURE", "OASES", "OASIS", "OBEDIENT", "OBSTACLE", "OBVIOUSLY", "OCCASION", "ORDINARILY", "ORDINARY", "ORGANIZATION", "PAMPHLET", "PANIC", "PANICKED", "PANICKY", "PARALLEL", "PARALYSIS", "PENICILLIN", "PEDESTRIAN", "PHANTOM", "PHEASANT", "PHRASE", "POLITELY", "POPULAR", "PRECIPITATION", "PRINCIPAL", "PRINCIPLE", "PRIVILEGE", "PROCEDURE", "PRONUNCIATION", "PSYCHOLOGY", "PUNY", "QUALIFIED", "QUALIFYING", "QUOTATION", "RASPBERRY", "REASONABLE", "RECEIPT", "RECEIVING", "RECIPE", "RECOGNITION", "RECOMMEND", "RECRUIT", "REDDEST", "REPRIMAND", "RESIGNED", "RESTAURANT", "ROTTEN", "SANDWICH", "SCARCITY", "SCENERY", "SECRETARY", "SECURING", "SIGNIFICANCE", "SIMILE", "SINCERELY", "SINCERITY", "SITUATION", "SLUMBER", "SMUDGE", "SOLEMN", "SOUVENIR", "SPACIOUS", "SPECIFIC", "STATIONARY", "STATIONERY", "STATISTICS", "SUBSCRIPTION", "SUBSTITUTE", "SUPERINTENDENT", "SUPERVISOR", "SUPPOSEDLY", "THREATENING", "TOLERATE", "TONGUE", "TOURNAMENT", "TRAGEDY", "TRAITOR", "TRANSFERRED", "TRANSFERRING", "TRANSMITTED",  "UNFORTUNATELY", "UNIFORM", "UNIVERSITY", "UNNECESSARY", "VALUABLE", "VARIOUS", "VEHICLE", "VERSION", "VERTICAL", "VICTIM", "VIGOROUSLY", "VIOLATION", "VISUALIZE", "VOLCANO", "VOYAGE", "WEALTHY", "WEAPON", "WHEEZE", "WILDERNESS" };
            String[] grade7 = new String[] { "ACCOMMODATE", "ABSTAIN", "ACCUMULATE", "ACCUSTOMED", "ACOUSTICS", "ACQUAINTANCE", "ACQUISITION", "ACQUITTAL", "ADOLESCENCE", "ADOLESCENT", "ADVANTAGEOUS", "AERIAL", "AMATEUR", "AMNESTY", "ANECDOTE", "ANNOYANCE", "ANONYMOUS", "ANTECEDENT", "ANTIDOTE", "ANTISEPTIC", "ANXIOUS", "APOLOGY", "APOSTROPHE", "APPENDIXES", "APPLICANT", "APPROXIMATE", "ARCHITECT", "ARRANGEMENT", "ASPHALT", "ASTERISK", "ASTHMA", "AWKWARD", "BACHELOR", "BANKRUPTCY", "BAROMETER", "BELLIGERENT", "BERSERK", "BESIEGED", "BIANNUAL", "BIMONTHLY", "BIOGRAPHICAL", "BRILLIANCE", "BUDGE", "BURGLARY", "CAMEOS", "CAPABLY",  "CARICATURE", "CATASTROPHE", "CHAMELEON", "CHANDELIER", "CHARACTERISTIC", "CHAUFFEUR", "CHRYSANTHEMUM", "CIRCUMFERENCE", "COLLABORATE", "COLLATERAL", "COLLEAGUE", "COLONEL", "CONFISCATE", "CONFISCATION", "CONSCIOUS", "CONSEQUENCE", "CONSIDERABLE", "CONTAGIOUS", "CONTROVERSY", "CONTINUOUS", "CORRELATION", "COUNCIL", "COUNSEL", "CRITICISM", "CRITICIZE", "CRITIQUE", "CRYPT", "CYLINDER", "DEFICIENCY", "DESIRABLE", "DESOLATE", "DETERRENT", "DIAGNOSIS", "DIALOGUE", "DILEMMA", "DISBURSEMENT", "DISCERNIBLE", "DISCREPANCY", "DOMINANCE", "EMBARGO",  "ENVIOUS", "EPIDEMIC", "EQUILIBRIUM", "ERRONEOUS", "ESCALATOR", "EXCESSIVE", "EXISTENCE", "EXTREMITY", "EXTRICATE", "FAÇADE", "FASHIONABLE", "FIASCO", "FIBROUS", "FIERY", "FLAMBOYANT", "FORGERY", "FRIVOLOUS", "FROSTBITTEN", "GLAMOROUS", "GORGEOUS", "GROTESQUE", "GYMNASIUM", "HAPHAZARD", "HAZARDOUS", "HEADQUARTERS", "HONORARY", "HORRIFIC", "HOSPITALITY", "INCIDENTALLY", "INCONVENIENCE", "INDULGENCE", "INEPT", "INEVITABLE", "INNUMERABLE", "INSISTENT", "INSUFFICIENT", "INTEGRITY", "INTERMITTENT", "INTERNALLY", "INTERROGATE", "LEGITIMATE", "LEISURE", "LIEUTENANT", "LONGEVITY", "LUCRATIVE", "LUNAR", "LUNCHEON", "LUXURIOUS", "MALADY", "MALICIOUS", "MALIGNANT", "MELODIOUS", "MERCENARY", "METEOR", "METICULOUS", "METROPOLITAN", "MINIMIZE", "MISCELLANEOUS", "MISCHIEVOUS", "NECESSITY", "NEGLIGENCE", "NEUTRAL",  "NOSTALGIA", "NOTICEABLE", "OBESITY", "OBSCURE", "OBSOLETE", "OBSTINATE", "OCCURRED", "OMINOUS", "OPTIMISM", "OPTIMISTIC", "OUTRAGEOUS", "PAGEANT", "PARACHUTE", "PARALYSIS", "PARLIAMENT", "PERCEIVE", "PERMEATE", "PERSEVERANCE", "PERSONALITY", "PERSONIFICATION", "PERSUADE", "PHENOMENON", "PLAINTIFF", "PNEUMONIA", "POLITICIAN", "POTENTIAL", "PRECIPICE", "PRECOCIOUS", "PREDECESSOR", "PREFERABLY", "PRESTIGIOUS", "PROCRASTINATE", "PROPELLER", "PROSPEROUS", "PROTEIN", "PSEUDONYM", "PSYCHIATRIST", "QUESTIONNAIRE", "RADIOACTIVE", "RAMPAGE", "RECURRENT", "REHEARSAL", "RELEVANT", "RELIGIOUS", "SACRIFICE", "SACRIFICIAL", "SANCTUARY", "SCANDALIZED", "SCHEDULE", "SCHEME", "SCHISM", "SCHOLAR", "SEMESTER", "SERVICEABLE", "SHRINE", "SHUDDERING", "SIEVE", "SNOBBERY", "SOLITARY", "STUDIOUS", "SUBTLETY", "SUBURBAN", "SURMISE", "SUSCEPTIBLE", "SUSPICIOUS", "TABOO", "TECHNICALLY", "TECHNOLOGY", "TYRANNY", "UNACCEPTABLE", "UNCONSCIOUS", "UNDERNOURISHED", "UNDULY", "UNENFORCEABLE", "UNIQUE", "UNIVERSAL", "UNPREDICTABLE", "UNSANITARY", "UTOPIA", "VACCINATE", "VACILLATE", "VENOM", "VERTIGO", "VESSEL", "VIGILANT", "VILLAIN", "VITAMIN", "VIVACIOUS", "VOCALIZE", "VORACIOUS", "VOUCHER", "VULNERABLE", "WITHHOLD" };
            String[] grade8 = new String[] { "ABSORPTION", "ACCOMPANIMENT", "ACCOMPLICE", "ACQUIESCE", "ACQUITTAL", "AFFILIATION", "ALTERCATION", "AMBASSADOR", "AMBIGUOUS", "ANIMOSITY", "APPARATUS", "APPROXIMATELY", "AUSTERITY", "AUTHENTIC", "AUTHENTICATE", "AUXILIARY", "BENEVOLENT", "BLASPHEMOUS", "BRAVADO", "CAMOUFLAGE", "CAPRICIOUS",  "CAVALCADE", "CELESTIAL", "CEREBRAL", "CHAGRIN", "CHAOTIC", "CHASM", "CHASTISE", "CHRONIC", "CITADEL", "CLIQUE", "COCOON", "CONCEIVABLE", "CONCURRENT", "CONSCIENTIOUS", "CONSCIOUSNESS", "CONTIGUOUS", "CORRESPONDENCE", "CORROBORATE", "CURRICULUM", "DEFAMATION", "DEPRIVATION", "DERELICT", "DIFFIDENCE", "DISASTROUS", "DISSOCIATE", "DISTINCTION", "DIURNAL", "DOMINANT", "DORMITORY", "DRUDGERY", "ELICIT", "ELIMINATION", "EMBROIDERY", "EQUINOX", "ESCAPADE", "ESPIONAGE", "ETIQUETTE", "EXAGGERATION", "EXEMPLARY", "EXPEDIENCY", "EXPEDIENT", "EXPUNGE", "FACSIMILE", "FALLACY", "FEASIBILITY", "FICTITIOUS", "FINESSE", "FLUORESCENT", "GRAMMATICALLY", "GRUESOME", "HANDKERCHIEF", "HIDEOUS", "HINDRANCE", "HOMOGENIZE", "HYPOCRISY", "IDIOSYNCRASY", "IMPASSE", "IMPROPRIETY", "INCANDESCENT", "INCESSANT", "INCONSOLABLE", "INDELIBLE", "INDISPENSABLE", "INDISPUTABLE", "INSUFFICIENT", "INTERROGATIVE", "IRRECONCILABLE", "IRRELEVANT", "IRREVOCABLE", "JUDICIOUS", "JUSTIFIABLE", "LABYRINTH", "LIAISON", "LUSTROUS", "MAGNANIMOUS", "MAGNIFICENCE", "MAINTENANCE", "MALICIOUS", "MARTYR", "MELEE", "METAMORPHOSIS", "MOLECULAR", "MONOTONY", "MOROSE", "MULTIPLICITY", "NAUSEA", "NONCHALANCE", "NOTORIETY", "OBLIQUE", "OCCASIONALLY", "OLFACTORY", "OMNIPOTENT", "ONOMATOPOEIA", "PALATABLE", "PANDEMONIUM", "PANORAMA", "PARTIALITY", "PASTIME", "PATRIARCH", "PERIL", "PERJURY", "PHILANTHROPIST", "PICTURESQUE", "PITTANCE", "PLAYWRIGHT", "POIGNANCY", "POIGNANT", "PREJUDICE", "PREMONITION", "PRIMITIVE", "PROXIMITY", "QUIBBLE", "QUIXOTIC", "QUIZZICAL", "RECIPIENT", "REDUNDANT", "REEK", "RELEVANCY", "REMEMBRANCE", "RENEGADE", "RENOVATE", "RESERVOIR", "RESPITE", "RETALIATE", "RETRIEVE", "ROCOCO", "SABOTAGE", "SALIENT", "SATISFACTORILY", "SAUNTER", "SCAVENGER", "SCOURGE", "SCUTTLE", "SEETHE", "SIGNIFICANCE", "SOLILOQUY", "SPASMODIC", "SQUALID", "STRENUOUS", "STRINGENT", "SUBSEQUENT", "SUBSISTENCE", "SUCCINCT", "SUMMARIZE", "SUPERSEDE", "SURGEON", "SURVEILLANCE", "SWELTER", "SYNTHESIS", "TANTALIZE", "TECHNICIAN", "TECHNIQUE", "TEDIOUS", "TENUOUS", "TIRADE", "TRANSCEND", "TRANSIENT", "TRANSMUTATION", "TREMOR", "TURBULENCE", "UBIQUITOUS", "ULTERIOR", "UNANIMOUS", "UNCANNY", "UNCOUTH", "UNDOUBTEDLY", "UNFORGETTABLE", "UPBRAID", "VARIEGATED", "VENGEANCE", "VERSATILE", "VOLATILE", "VULNERABLE", "VYING", "WARY" };
            String[] grade9 = new String[] { "ABSENCE", "EXCELLENT", "PNEUMONIA", "ACCIDENTALLY", "EXCITEMENT", "POSSESS", "ACCOMMODATE", "EXPERIENCE", "PRACTICALLY", "ACHIEVE", "FAMILIAR", "PREFERRED", "ACQUAINTANCE", "FASCINATE", "PRIVILEGE", "AGAINST", "PROBABLY", "A", "LOT", "FEBRUARY", "RASPBERRY", "ALREADY", "FINALLY", "REALIZE", "ARGUMENT", "FOREIGN", "RECEIVE", "ATTENDANCE", "FRIEND", "RECOMMEND", "BECAUSE", "GOVERNMENT", "REMEMBER", "BEGINNING", "GRAMMAR", "RESTAURANT", "BELIEVE", "GUARANTEE", "RHYTHM", "BUSINESS", "HEIGHT", "RIDICULOUS", "CALENDAR", "IMMEDIATELY", "SCHEDULE", "CEMETERY", "INDEPENDENT", "SCISSORS", "CHIEF", "INSTEAD", "SEPARATE", "COMMITTEE", "INTERRUPT", "SIMILAR", "CONSCIENCE", "SINCERELY", "CONVENIENCE", "LEISURE", "STRAIGHT", "COURAGEOUS", "LIBRARY", "STRENGTHEN", "CRITICIZE", "LIGHTNING", "STUDYING", "DECISION", "LONELY", "SUMMARIZE", "DEFINITELY", "LYING", "SURPRISE", "DESPERATELY", "MILLIONAIRE", "THOROUGH", "DICTIONARY", "MISCHIEVOUS", "TOMORROW", "DIFFERENT", "NECESSARY", "TRULY", "DISEASE", "NIECE", "UNTIL",  "NOTICEABLE", "VACUUM", "EMBARRASS", "OCCASION", "VEGETABLE", "ENOUGH", "OCCURRED", "WEDNESDAY", "ENVIRONMENT", "OPPOSITE", "WEIGHT", "ESPECIALLY", "PARTICULAR", "WEIRD", "EXAGGERATE", "PHYSICAL", "YACHT" };
            int randomNo;
            
             spellings = new List<String>();
             spellings.Add("default");
            int i;
            Random rnd = new Random();
            for (i = 0; i < 3; i++)
            {
                
                randomNo = rnd.Next(1, grade1.Length);
                spellings.Add(grade1[randomNo]);
            }
            
            for (i = 0; i < 3; i++)
            {
               
                randomNo = rnd.Next(1, grade2.Length);
                spellings.Add(grade2[randomNo]);
            }
            for (i = 0; i < 3; i++)
            {
               
                randomNo = rnd.Next(1, grade3.Length);
                spellings.Add(grade3[randomNo]);
            }
            for (i = 0; i < 4; i++)
            {
               
                randomNo = rnd.Next(1, grade4.Length);
                spellings.Add(grade4[randomNo]);
            }
            for (i = 0; i < 4; i++)
            {
                
                randomNo = rnd.Next(1, grade5.Length);
                spellings.Add(grade5[randomNo]);
            }
            for (i = 0; i < 5; i++)
            {
                
                randomNo = rnd.Next(1, grade6.Length);
                spellings.Add(grade6[randomNo]);
            }
            for (i = 0; i < 6; i++)
            {
                
                randomNo = rnd.Next(1, grade7.Length);
                spellings.Add(grade7[randomNo]);
            }
              
            for (i = 0; i < 7; i++)
            {
                
                randomNo = rnd.Next(1, grade8.Length);
                spellings.Add(grade8[randomNo]);
            }
             
            for (i = 0; i < 10; i++)
            {
                
                randomNo = rnd.Next(1, grade9.Length);
                spellings.Add(grade9[randomNo]);
            }
            for (i = 0; i < 10; i++)
            {

                randomNo = rnd.Next(1, grade8.Length);
                spellings.Add(grade8[randomNo]);
            }
            for (i = 0; i < 10; i++)
            {

                randomNo = rnd.Next(1, grade7.Length);
                spellings.Add(grade7[randomNo]);
            }
            for (i = 0; i < 10; i++)
            {

                randomNo = rnd.Next(1, grade9.Length);
                spellings.Add(grade9[randomNo]);
            }
	



        }


        List<String> spellings;
        String[] initialSpell = new String[] { "Can you spell, ", "Spell, " };
        int initialSpellFlag = 0;
        int[] voiceOver = new int[]{1,0,0,1};
        int voiceOverFlag = 0;
        int score=10,question=1,life=5;

        public void startGame()
        {

            listenToWord();
            wordGuessed.Text = "";


        }
        private async void listenToWord()
        {
            if (initialSpellFlag == 0)
                initialSpellFlag = 1;
            else
                initialSpellFlag = 0;

            if (voiceOverFlag == 0)
                voiceOverFlag = 1;
            else if (voiceOverFlag == 1)
                voiceOverFlag = 2;
            else if (voiceOverFlag == 2)
                voiceOverFlag = 3;
            else
                voiceOverFlag = 0;


            SpeechSynthesizer synth = new SpeechSynthesizer();
            IEnumerable<VoiceInformation> englishVoices = from voice in InstalledVoices.All
                                                         where voice.Language == "en-US"
                                                         select voice;
            synth.SetVoice(englishVoices.ElementAt(voiceOver[voiceOverFlag]));
            letters.Text = spellings[question].Length + " Letters";
            await synth.SpeakTextAsync(initialSpell[initialSpellFlag]+ spellings[question]);
            
        }


        private async void ButtonSimpleTTS_Click(object sender, RoutedEventArgs e)
        {
            /* animation
            BitmapImage imgSource;
            
            imgSource = new BitmapImage(new Uri("Assets/2.png", UriKind.Relative));
            image.Source = imgSource;
            imgSource = new BitmapImage(new Uri("Assets/3.png", UriKind.Relative));
            image.Source = imgSource;
            imgSource = new BitmapImage(new Uri("Assets/4.png", UriKind.Relative));
            image.Source = imgSource;
            imgSource = new BitmapImage(new Uri("Assets/5.png", UriKind.Relative));
            image.Source = imgSource;
            imgSource = new BitmapImage(new Uri("Assets/6.png", UriKind.Relative));
            image.Source = imgSource;

            */
            speakerplus2.Begin();

            if (initialSpellFlag == 0)
                initialSpellFlag = 1;
            else
                initialSpellFlag = 0;

            if (voiceOverFlag == 0)
                voiceOverFlag = 1;
            else if (voiceOverFlag == 1)
                voiceOverFlag = 2;
            else if (voiceOverFlag == 2)
                voiceOverFlag = 3;
            else
                voiceOverFlag = 0;


            SpeechSynthesizer synth = new SpeechSynthesizer();
            IEnumerable<VoiceInformation> englishVoices = from voice in InstalledVoices.All
                                                          where voice.Language == "en-US"
                                                          select voice;
            synth.SetVoice(englishVoices.ElementAt(voiceOver[voiceOverFlag]));

            await synth.SpeakTextAsync(initialSpell[initialSpellFlag] + spellings[question]);

          
           

        }

        private async void endMessage()
        {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                   
                    await synth.SpeakTextAsync("Here, are the High Scores");


         }
        private async void winMessage()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            await synth.SpeakTextAsync("You, are the winner !");


        }
        private void QPress(object sender, RoutedEventArgs e)
        {
            wordGuessed.Text = wordGuessed.Text + "Q";
            sound_main1.Play();
        }
        private void WPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "W"; }
        private void EPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "E"; }
        private void RPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "R"; }
        private void TPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "T"; }
        private void YPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "Y"; }
        private void UPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "U"; }
        private void IPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "I"; }
        private void OPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "O"; }
        private void PPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "P"; }
        private void APress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "A"; }
        private void SPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "S"; }
        private void DPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "D"; }
        private void FPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "F"; }
        private void GPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "G"; }
        private void HPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "H"; }
        private void JPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "J"; }
        private void KPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "K"; }
        private void LPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "L"; }
        private void ZPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "Z"; }
        private void XPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "X"; }
        private void CPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "C"; }
        private void VPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "V"; }
        private void BPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "B"; }
        private void NPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "N"; }
        private void MPress(object sender, RoutedEventArgs e) { sound_main1.Play(); wordGuessed.Text = wordGuessed.Text + "M"; }

        public void delete(object sender, EventArgs e) {
            if(wordGuessed.Text.Length>0)
            wordGuessed.Text = wordGuessed.Text.Remove(wordGuessed.Text.Length - 1);
            sound_main1.Play();
        }

        public void submit(object sender, EventArgs e)
        {
            if (wordGuessed.Text.Equals(spellings[question]))
            {
                //music
                sound_main2.Play();


                //animation
                scoreplus.Begin();
                
                

                //code
                question++;
                if (question == 75)
                {
                    winMessage();
                    stringCompleter();
                    NavigationService.Navigate(new Uri("/highscores.xaml?score=100000", UriKind.Relative));
                    score = 10;
                    question = 1;
                    life = 5;
                    lifedisplay.Text = "LIFE: Immortal";
                    scoredisplay.Text = "SCORE: TILT" ;
                }
                    
                    
                    
                    //score increment
                if(question>=1&&question<3)
                score += 10;
                else if (question>=3 && question <7 )
                score += 20;
                else if (question>=7 && question <10 )
                score += 40;
                else if (question>=10 && question <16 )
                score += 60;
                else if (question>=16 && question <25 )
                score += 80;
                else if (question>=25 && question <40 )
                score += 100;
                else if (question>=40 && question <60 )
                score += 150;
                else
                score +=200;






                scoredisplay.Text = "SCORE: " + score;
                startGame();

            }
            else
            {
            //   music 
                sound_main3.Play();
                
                //code
                
                life--;
                lifedisplay.Text = "LIFE: " + life;
                if (life == 0)
                {
                    
                    wordGuessed.Text = spellings[question];
                    endMessage();
                    stringCompleter();



                    NavigationService.Navigate(new Uri("/highscores.xaml?score="+score, UriKind.Relative));
                     //reseting the scores
                    
                    score=10;
                     question = 1;
                        life = 5;

                        lifedisplay.Text = "LIFE: " + life;

                        scoredisplay.Text = "SCORE: " + score;

                }
                lifeplus.Begin();
            }
        }
        
       
    }
}