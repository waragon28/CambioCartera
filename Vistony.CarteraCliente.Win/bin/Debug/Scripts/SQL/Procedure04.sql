CREATE PROCEDURE SP_VIS_SEARCH_RECEIPS(
IN OP VARCHAR(20),
IN BANK VARCHAR(20),
IN SLPCODE VARCHAR(20)
)
AS
BEGIN
	
	SELECT
	"Code"
	,"U_VIS_Deposit" "Deposito"
	,"U_VIS_CardCode" "Cliente"
	,"U_VIS_DocNum" "Documento"
	,CASE "U_VIS_Status" WHEN 'P' THEN 'Pendiente' WHEN 'A' THEN 'Anulado' WHEN 'C' THEN 'Conciliado' WHEN 'M' THEN 'Manual' END "Estado"
	,"U_VIS_AmountCharged" "Monto"
	,"U_VIS_IncomeDate" "Fecha"
	,DAYS_BETWEEN("U_VIS_IncomeDate", CURRENT_DATE) "D�as"
	,"U_VIS_Receip" "Recibo"
	FROM "@VIST_COBRANZA1"
	WHERE "U_VIS_Deposit" = :OP
	AND "U_VIS_BankID" = :BANK
	AND "U_VIS_SlpCode" = :SLPCODE
	AND "U_VIS_Status"<>'A';	
END;