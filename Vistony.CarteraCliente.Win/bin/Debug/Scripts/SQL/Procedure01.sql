

CREATE PROCEDURE P_VIS_VEN_UPD_SOCNEG_VEND (IN SLPCODE VARCHAR(50) ) 
AS BEGIN SELECT  'Y' as "Seleccionar",T0."CardCode",CASE T0."AdresType" WHEN 'S' THEN 'bo_ShipTo' WHEN 'B' THEN 'bo_BillTo' END "AdresType" ,T0."LineNum",T0."Address",T1."CardName",T0."Block",T0."City",T0."County",T2."Name","U_VIS_VisitOrder" 
FROM CRD1 T0 INNER JOIN OCRD T1 ON T1."CardCode"=T0."CardCode" LEFT JOIN "@VIST_TERRITORIO" T2 ON T2."Code"=T0."U_VIS_TerritoryID" WHERE "U_VIS_SlpCode"= SLPCODE; END;


