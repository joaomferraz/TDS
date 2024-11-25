Û	
ÄC:\Users\jmach\OneDrive\Documents\UTFPR\TDS\ControleEstoque\ControleEstoque\Intefaces\Repositorios\IRepositorioCRUDGenericoEF.cs
	namespace 	
ControleEstoque
 
. 
Modelo  
.  !
	Intefaces! *
.* +
Repositorios+ 7
;7 8
public 
	interface &
IRepositorioCRUDGenericoEF +
<+ ,
T, -
>- .
where/ 4
T5 6
:7 8
class9 >
{ 
void 
	Adicionar 
( 
object 
tabela $
,$ %
T& '
entidade( 0
)0 1
;1 2
IEnumerable

 
<

 
T

 
>

 

ObterTodos

 !
(

! "
object

" (
tabela

) /
)

/ 0
;

0 1
T 	
?	 


ObterPorId 
( 
int 
id 
) 
; 
void 
	Atualizar 
( 
T 
entidade !
)! "
;" #
void 
Remover 
( 
T 
entidade 
)  
;  !
} è	
~C:\Users\jmach\OneDrive\Documents\UTFPR\TDS\ControleEstoque\ControleEstoque\Intefaces\Repositorios\IRepositorioCRUDGenerico.cs
	namespace 	
ControleEstoque
 
. 
Modelo  
.  !
	Intefaces! *
.* +
Repositorios+ 7
;7 8
public 
	interface $
IRepositorioCRUDGenerico )
<) *
T* +
>+ ,
where- 2
T3 4
:5 6
class7 <
{ 
void 
	Adicionar 
( 
T 
entidade !
)! "
;" #
IEnumerable

 
<

 
T

 
>

 

ObterTodos

 !
(

! "
)

" #
;

# $
T 	
?	 


ObterPorId 
( 
int 
id 
) 
; 
void 
	Atualizar 
( 
T 
entidade !
)! "
;" #
void 
Remover 
( 
T 
entidade 
)  
;  !
} 