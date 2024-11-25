�
]C:\Users\jmach\OneDrive\Documents\UTFPR\TDS\ControleEstoque\ControleEstoque.WebAPI\Program.cs
var 
builder 
= 
WebApplication 
. 

(* +
args+ /
)/ 0
;0 1
builder 
. 
Services 
. #
AddEndpointsApiExplorer (
(( )
)) *
;* +
builder		 
.		 
Services		 
.		 

(		 
)		  
;		  !
builder

 
.

 
Services

 
.

 
AddDbContext

 
<

 (
ControleEstoqueEFCoreContext

 :
>

: ;
(

; <
options

< C
=>

D F
options

G N
.

N O
	UseSqlite

O X
(

X Y
builder 
. 

. 
GetConnectionString -
(- .
$str. A
)A B
) 
) 
; 
builder
.
Services
.
AddControllers
(
)
;
var 
app 
= 	
builder
 
. 
Build 
( 
) 
; 
app 
. 

UseRouting 
( 
) 
; 
if 
( 
app 
. 
Environment 
. 

(! "
)" #
)# $
{ 
app 
. 

UseSwagger 
( 
) 
; 
app 
. 
UseSwaggerUI 
( 
) 
; 
} 
app 
. 
UseEndpoints 
( 
	endpoints 
=> 
{ 
	endpoints 
.
MapControllers 
( 
) 
; 
} 
) 
; 
app 
. 
UseHttpsRedirection 
( 
) 
; 
app 
. 
Run 
( 
) 	
;	 
�9
iC:\Users\jmach\OneDrive\Documents\UTFPR\TDS\ControleEstoque\ControleEstoque.WebAPI\Controller\Supplier.cs
	namespace 	
ControleEstoque
 
. 
WebAPI  
.  !

Controller! +
{ 
[ 
Route 

(
 
$str 
) 
] 
[		 

]		 
public

 

class

 
SupplierController

 #
:

$ %
ControllerBase

& 4
{ 
private 
readonly (
ControleEstoqueEFCoreContext 5
context6 =
;= >
public 
SupplierController !
(! "(
ControleEstoqueEFCoreContext" >
context? F
)F G
{ 	
this 
. 
context 
= 
context "
;" #
} 	
[ 	
HttpGet	 
] 
public 
async 
Task 
< 

>' (
GetAll) /
(/ 0
)0 1
{ 	
var 
	suppliers 
= 
await !
context" )
.) *
	Suppliers* 3
. 
Include 
( 
s 
=> 
s 
.  
Product  '
)' (
. 
ToListAsync 
( 
) 
; 
return 
Ok 
( 
	suppliers 
)  
;  !
} 	
[ 	
HttpGet	 
( 
$str 
) 
] 
public 
async 
Task 
< 

>' (
GetByID) 0
(0 1
int1 4

supplierID5 ?
)? @
{   	
var!! 
supplier!! 
=!! 
await!!  
context!!! (
.!!( )
	Suppliers!!) 2
."" 
Include"" 
("" 
s"" 
=>"" 
s"" 
.""  
Product""  '
)""' (
.## 
FirstOrDefaultAsync## $
(##$ %
s##% &
=>##' )
s##* +
.##+ ,

SupplierID##, 6
==##7 9

supplierID##: D
)##D E
;##E F
if%% 
(%% 
supplier%% 
==%% 
null%%  
)%%  !
{&& 
return'' 
NotFound'' 
(''  
$"''  "
$str''" 3
{''3 4

supplierID''4 >
}''> ?
$str''? I
"''I J
)''J K
;''K L
}(( 
return)) 
Ok)) 
()) 
supplier)) 
))) 
;))  
}** 	
[,, 	
HttpGet,,	 
(,, 
$str,, (
),,( )
],,) *
public-- 
async-- 
Task-- 
<-- 

>--' (!
GetProductsBySupplier--) >
(--> ?
int--? B

supplierID--C M
)--M N
{.. 	
var// 
supplier// 
=// 
await//  
context//! (
.//( )
	Suppliers//) 2
.00 
Include00 
(00 
s00 
=>00 
s00 
.00  
Product00  '
)00' (
.11 
FirstOrDefaultAsync11 $
(11$ %
s11% &
=>11' )
s11* +
.11+ ,

SupplierID11, 6
==117 9

supplierID11: D
)11D E
;11E F
if33 
(33 
supplier33 
==33 
null33  
)33  !
{44 
return55 
NotFound55 
(55  
$"55  "
$str55" 3
{553 4

supplierID554 >
}55> ?
$str55? I
"55I J
)55J K
;55K L
}66 
return88 
Ok88 
(88 
supplier88 
.88 
Product88 &
)88& '
;88' (
}99 	
[== 	
HttpPost==	 
]== 
public>> 
async>> 
Task>> 
<>> 

>>>' (
Create>>) /
(>>/ 0
[>>0 1
FromBody>>1 9
]>>9 :
Supplier>>; C
supplier>>D L
)>>L M
{?? 	
context@@ 
.@@ 
	Suppliers@@ 
.@@ 
Add@@ !
(@@! "
supplier@@" *
)@@* +
;@@+ ,
awaitAA 
contextAA 
.AA 
SaveChangesAsyncAA *
(AA* +
)AA+ ,
;AA, -
returnBB 
CreatedAtActionBB "
(BB" #
nameofBB# )
(BB) *
GetByIDBB* 1
)BB1 2
,BB2 3
newBB4 7
{BB8 9

supplierIDBB: D
=BBE F
supplierBBG O
.BBO P

SupplierIDBBP Z
}BB[ \
,BB\ ]
supplierBB^ f
)BBf g
;BBg h
}CC 	
[FF 	
HttpPutFF	 
]FF 
publicGG 
asyncGG 
TaskGG 
<GG 

>GG' (
UpdateGG) /
(GG/ 0
[GG0 1
FromBodyGG1 9
]GG9 :
SupplierGG; C
supplierGGD L
)GGL M
{HH 	
contextII 
.II 
EntryII 
(II 
supplierII "
)II" #
.II# $
StateII$ )
=II* +
EntityStateII, 7
.II7 8
ModifiedII8 @
;II@ A
awaitJJ 
contextJJ 
.JJ 
SaveChangesAsyncJJ *
(JJ* +
)JJ+ ,
;JJ, -
returnKK 
OkKK 
(KK 
supplierKK 
)KK 
;KK  
}LL 	
[OO 	

HttpDeleteOO	 
]OO 
publicPP 
asyncPP 
TaskPP 
<PP 

>PP' (

DeleteByIdPP) 3
(PP3 4
intPP4 7

supplierIDPP8 B
)PPB C
{QQ 	
varRR 
supplierRR 
=RR 
awaitRR  
contextRR! (
.RR( )
	SuppliersRR) 2
.RR2 3
	FindAsyncRR3 <
(RR< =

supplierIDRR= G
)RRG H
;RRH I
ifSS 
(SS 
supplierSS 
==SS 
nullSS  
)SS  !
{TT 
returnUU 
NotFoundUU 
(UU  
$"UU  "
$strUU" 3
{UU3 4

supplierIDUU4 >
}UU> ?
$strUU? I
"UUI J
)UUJ K
;UUK L
}VV 
contextXX 
.XX 
	SuppliersXX 
.XX 
RemoveXX $
(XX$ %
supplierXX% -
)XX- .
;XX. /
awaitYY 
contextYY 
.YY 
SaveChangesAsyncYY *
(YY* +
)YY+ ,
;YY, -
returnZZ 
	NoContentZZ 
(ZZ 
)ZZ 
;ZZ 
}[[ 	
}\\ 
}]] �0
hC:\Users\jmach\OneDrive\Documents\UTFPR\TDS\ControleEstoque\ControleEstoque.WebAPI\Controller\Product.cs
	namespace 	
ControleEstoque
 
. 
WebAPI  
.  !

Controller! +
{ 
[ 
Route 

(
 
$str 
) 
] 
[		 

]		 
public

 

class

 
ProductController

 "
:

# $
ControllerBase

% 3
{ 
private 
readonly (
ControleEstoqueEFCoreContext 5
context6 =
;= >
public 
ProductController  
(  !(
ControleEstoqueEFCoreContext! =
context> E
)E F
{ 	
this 
. 
context 
= 
context "
;" #
} 	
[ 	
HttpGet	 
] 
public 
async 
Task 
< 

>' (
GetAll) /
(/ 0
)0 1
{ 	
var 
products 
= 
await  
context! (
.( )
Products) 1
. 
Include 
( 
p 
=> 
p 
.  
Supplier  (
)( )
. 
Include 
( 
p 
=> 
p 
.  
Category  (
)( )
. 
ToListAsync 
( 
) 
; 
return 
Ok 
( 
products 
) 
;  
} 	
[ 	
HttpGet	 
( 
$str 
) 
] 
public   
async   
Task   
<   

>  ' (
GetByID  ) 0
(  0 1
int  1 4
	productID  5 >
)  > ?
{!! 	
var"" 
product"" 
="" 
await"" 
context""  '
.""' (
Products""( 0
.## 
Include## 
(## 
p## 
=>## 
p## 
.##  
Supplier##  (
)##( )
.$$ 
Include$$ 
($$ 
p$$ 
=>$$ 
p$$ 
.$$  
Category$$  (
)$$( )
.%% 
FirstOrDefaultAsync%% $
(%%$ %
p%%% &
=>%%' )
p%%* +
.%%+ ,
	ProductID%%, 5
==%%6 8
	productID%%9 B
)%%B C
;%%C D
if'' 
('' 
product'' 
=='' 
null'' 
)''  
{(( 
return)) 
NotFound)) 
())  
$"))  "
$str))" 2
{))2 3
	productID))3 <
}))< =
$str))= G
"))G H
)))H I
;))I J
}** 
return++ 
Ok++ 
(++ 
product++ 
)++ 
;++ 
},, 	
[// 	
HttpPost//	 
]// 
public00 
async00 
Task00 
<00 

>00' (
Create00) /
(00/ 0
[000 1
FromBody001 9
]009 :
Product00; B
product00C J
)00J K
{11 	
context22 
.22 
Products22 
.22 
Add22  
(22  !
product22! (
)22( )
;22) *
await33 
context33 
.33 
SaveChangesAsync33 *
(33* +
)33+ ,
;33, -
return44 
CreatedAtAction44 "
(44" #
nameof44# )
(44) *
GetByID44* 1
)441 2
,442 3
new444 7
{448 9
	productID44: C
=44D E
product44F M
.44M N
	ProductID44N W
}44X Y
,44Y Z
product44[ b
)44b c
;44c d
}55 	
[88 	
HttpPut88	 
]88 
public99 
async99 
Task99 
<99 

>99' (
Update99) /
(99/ 0
[990 1
FromBody991 9
]999 :
Product99; B
product99C J
)99J K
{:: 	
context;; 
.;; 
Entry;; 
(;; 
product;; !
);;! "
.;;" #
State;;# (
=;;) *
EntityState;;+ 6
.;;6 7
Modified;;7 ?
;;;? @
await<< 
context<< 
.<< 
SaveChangesAsync<< *
(<<* +
)<<+ ,
;<<, -
return== 
Ok== 
(== 
product== 
)== 
;== 
}>> 	
[AA 	

HttpDeleteAA	 
]AA 
publicBB 
asyncBB 
TaskBB 
<BB 

>BB' (

DeleteByIdBB) 3
(BB3 4
intBB4 7
	productIDBB8 A
)BBA B
{CC 	
varDD 
productDD 
=DD 
awaitDD 
contextDD  '
.DD' (
ProductsDD( 0
.DD0 1
	FindAsyncDD1 :
(DD: ;
	productIDDD; D
)DDD E
;DDE F
ifEE 
(EE 
productEE 
==EE 
nullEE 
)EE  
{FF 
returnGG 
NotFoundGG 
(GG  
$"GG  "
$strGG" 2
{GG2 3
	productIDGG3 <
}GG< =
$strGG= G
"GGG H
)GGH I
;GGI J
}HH 
contextJJ 
.JJ 
ProductsJJ 
.JJ 
RemoveJJ #
(JJ# $
productJJ$ +
)JJ+ ,
;JJ, -
awaitKK 
contextKK 
.KK 
SaveChangesAsyncKK *
(KK* +
)KK+ ,
;KK, -
returnLL 
	NoContentLL 
(LL 
)LL 
;LL 
}MM 	
}NN 
}OO �(
gC:\Users\jmach\OneDrive\Documents\UTFPR\TDS\ControleEstoque\ControleEstoque.WebAPI\Controller\Person.cs
	namespace 	
ControleEstoque
 
. 
WebAPI  
.  !
Controllers! ,
;, -
[ 
Route 
( 
$str 
) 
] 
[		 

]		 
public

 
class

 
PersonController


:

 
ControllerBase

  .
{

/ 0
private 
readonly (
ControleEstoqueEFCoreContext 1
context2 9
;9 :
public

PersonController
(
ControleEstoqueEFCoreContext
context
)
{
this 
. 
context
= 
context 
; 
} 
[ 
HttpGet 
] 
public 

async 
Task 
< 

># $
GetAll% +
(+ ,
), -
{. /
var 
persons 
= 
await 
context #
.# $
Persons$ +
.+ ,
ToListAsync, 7
(7 8
)8 9
;9 :
return 
Ok 
( 
persons 
) 
; 
} 
[ 
HttpGet 
( 
$str
) 
] 
public 

async 
Task 
< 

># $
GetByID% ,
(, -
int- 0
personID1 9
)9 :
{; <
Person 
? 
person 
= 
await 
context &
.& '
Persons' .
.. /
	FindAsync/ 8
(8 9
personID9 A
)A B
;B C
if 

( 
person 
== 
null 
) 
{ 
return 
NotFound 
( 
$" 
$str -
{- .
personID. 6
}6 7
$str7 A
"A B
)B C
;C D
} 	
return 
Ok 
( 
person 
) 
; 
} 
[   
HttpPost   
]  
[!! 
Produces!! 
(!!
$str!!  
)!!  !
]!!! "
public"" 

async"" 
Task"" 
<"" 

>""# $
Create""% +
(""+ ,
["", -
FromBody""- 5
]""5 6
Person""6 <
person""= C
)""C D
{""E F
context## 
.## 
Add## 
(## 
person## 
)## 
;## 
await$$ 
context$$ 
.$$ 
SaveChangesAsync$$ &
($$& '
)$$' (
;$$( )
return%% 
Created%% 
(%% 
$str%% 
,%% 
person%% !
)%%! "
;%%" #
}&& 
[(( 

HttpDelete(( 
](( 
public)) 

async)) 
Task)) 
<)) 

>))# $

DeleteById))% /
())/ 0
int))0 3
personID))4 <
)))< =
{))> ?
Person** 
?** 
person** 
=** 
await** 
context** &
.**& '
Persons**' .
.**. /
	FindAsync**/ 8
(**8 9
personID**9 A
)**A B
;**B C
if++ 

(++ 
person++ 
!=++ 
null++ 
)++ 
{++ 
context,, 
.,, 
Remove,, 
(,, 
person,, !
),,! "
;,," #
await-- 
context-- 
.-- 
SaveChangesAsync-- *
(--* +
)--+ ,
;--, -
return.. 
Ok.. 
(.. 
).. 
;.. 
}// 	
return00 
	NoContent00 
(00 
)00 
;00 
}11 
[33 
HttpPut33 
]33 
public44 

async44 
Task44 
<44 

>44# $
Update44% +
(44+ ,
Person44, 2
person443 9
)449 :
{44; <
context55 
.55 
Entry55 
(55 
person55 
)55 
.55 
State55 #
=55$ %
EntityState55& 1
.551 2
Modified552 :
;55: ;
await66 
context66 
.66 
SaveChangesAsync66 &
(66& '
)66' (
;66( )
return77 
Ok77 
(77 
person77 
)77 
;77 
}88 
}99 �'
iC:\Users\jmach\OneDrive\Documents\UTFPR\TDS\ControleEstoque\ControleEstoque.WebAPI\Controller\Category.cs
	namespace 	
ControleEstoque
 
. 
WebAPI  
.  !

Controller! +
;+ ,
[		 
Route		 
(		 
$str		 
)		 
]		 
[

 


 
]

 
public 
class 
CategoryController
:  !
ControllerBase" 0
{1 2
private 
readonly (
ControleEstoqueEFCoreContext 1
context2 9
;9 :
public 

CategoryController 
( (
ControleEstoqueEFCoreContext :
context; B
)B C
{C D
this 
. 
context
= 
context 
; 
} 
[ 
HttpGet 
] 
public 

async 
Task 
< 

># $
GetAll% +
(+ ,
), -
{. /
var 

categories 
= 
await 
context &
.& '

Categories' 1
.1 2
ToListAsync2 =
(= >
)> ?
;? @
return 
Ok 
( 

categories 
) 
; 
} 
[ 
HttpGet 
( 
$str
) 
] 
public 

async 
Task 
< 

># $
GetByID% ,
(, -
int- 0

categoryID1 ;
); <
{= >

? 
category 
=  !
await" '
context( /
./ 0

Categories0 :
.: ;
	FindAsync; D
(D E

categoryIDE O
)O P
;P Q
if 

( 
category 
== 
null 
) 
{ 
return 
NotFound 
( 
$" 
$str /
{/ 0

categoryID0 :
}: ;
$str; E
"E F
)F G
;G H
} 	
return 
Ok 
( 
category 
) 
; 
} 
[!! 
HttpPost!! 
]!!
public"" 

async"" 
Task"" 
<"" 

>""# $
Create""% +
(""+ ,

category"": B
)""B C
{""D E
context## 
.## 
Add## 
(## 
category## 
)## 
;## 
await$$ 
context$$ 
.$$ 
SaveChangesAsync$$ &
($$& '
)$$' (
;$$( )
return%% 
Created%% 
(%% 
$str%% 
,%% 
category%% #
)%%# $
;%%$ %
}&& 
[(( 

HttpDelete(( 
](( 
public)) 

async)) 
Task)) 
<)) 

>))# $

DeleteById))% /
())/ 0
int))0 3

categoryID))4 >
)))> ?
{))@ A

?** 
category** 
=**  !
await**" '
context**( /
.**/ 0

Categories**0 :
.**: ;
	FindAsync**; D
(**D E

categoryID**E O
)**O P
;**P Q
if++ 

(++ 
category++ 
!=++ 
null++ 
)++ 
{++ 
context,, 
.,, 
Remove,, 
(,, 
category,, #
),,# $
;,,$ %
await-- 
context-- 
.-- 
SaveChangesAsync-- *
(--* +
)--+ ,
;--, -
return.. 
Ok.. 
(.. 
).. 
;.. 
}// 	
return00 
	NoContent00 
(00 
)00 
;00 
}11 
[33 
HttpPut33 
]33 
public44 

async44 
Task44 
<44 

>44# $
Update44% +
(44+ ,

category44: B
)44B C
{44D E
context55 
.55 
Entry55 
(55 
category55 
)55 
.55  
State55  %
=55& '
EntityState55( 3
.553 4
Modified554 <
;55< =
await66 
context66 
.66 
SaveChangesAsync66 &
(66& '
)66' (
;66( )
return77 
Ok77 
(77 
category77 
)77 
;77 
}88 
}99 