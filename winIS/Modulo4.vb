Imports System.Math

Public Class EPQ2
    Dim D, P, H, B, K, T, dd, tl, U As Single
    'D - Demanda anual
    'P - Costo de preparar una tanda
    'H - Costo de mantener inventario
    'B - Costo de carecer de una unidad (faltante)
    'K - Producción diaria
    'T - Días al año
    'dd - Demanda diaria
    'tl - Tiempo de preparación
    'U - Costo por unidad

    'Constructor, asigna los datos de entrada a las variables correspondientes
    Sub New(ByVal val As Array)
        D = val(0)
        P = val(1)
        H = val(2)
        B = val(3)
        K = val(4)
        T = val(5)
        dd = val(6)
        tl = val(7)
        U = val(8)
    End Sub

    'Tamaño del lote optimo a producir
    Function TamañoLote()
        Dim Q As Single
        Q = ((2 * P * D * (H + B)) / (H * B * (1 - (dd / K)))) ^ (1 / 2)
        Return Q
    End Function

    'Acumulación de faltantes
    Function Deficit()
        Dim S As Single
        S = ((2 * P * D * H * (1 - (dd / K))) / ((B + H) * B)) ^ (1 / 2)
        Return S
    End Function

    'Tamaño del inventario máximo
    Function InventarioMaximo()
        Dim Imax As Single
        Imax = (TamañoLote() * (1 - (dd / K))) - Deficit()
        Imax = Round(Imax, 2)
        Return Imax
    End Function

    'Número de tandas necesarias
    Function Ntandas()
        Dim N As Single
        N = D / TamañoLote()
        N = Round(N, 2)
        Return N
    End Function

    'Duración del ciclo
    Function TiempoCiclo()
        Dim Tc As Single
        Tc = (TamañoLote() / D) * T
        Tc = Round(Tc, 2)
        Return Tc
    End Function

    'Tiempo de producción
    Public Function TiempoProduccion() As Single
        Dim tp As Single
        tp = TamañoLote() / K
        Return tp
    End Function

    'Tiempo de consumo
    Public Function TiempoConsumo() As Single
        Dim td As Single
        td = InventarioMaximo() / dd
        Return td
    End Function

    'Tiempo de faltante
    Function TiempoFaltante()
        Dim Tf As Single
        Tf = Deficit() / dd
        Tf = Round(Tf, 2)
        Return Tf
    End Function

    'Punto de reorden
    Function PuntoReorden()
        Dim L As Single
        L = -Deficit() + (dd * tl)
        L = Round(L, 2)
        Return L
    End Function

    'Costo total de preparación
    Function CostoTotalPreparar()
        Dim CTp As Single
        CTp = (P * D) / TamañoLote()
        CTp = Round(CTp, 2)
        Return CTp
    End Function

    'Costo total de mantener en inventario
    Function CostoTotalMantener()
        Dim CTh As Single
        CTh = (H / (2 * TamañoLote() * (1 - (dd / K)))) * (((TamañoLote() * (1 - (dd / K))) - Deficit()) ^ 2)
        CTh = Round(CTh, 2)
        Return CTh
    End Function

    'Costo total de faltantes
    Function CostoTotalFaltante()
        Dim CTb As Single
        CTb = (B * (Deficit() ^ 2)) / (2 * TamañoLote() * (1 - (dd / K)))
        CTb = Round(CTb, 2)
        Return CTb
    End Function

    'Costo total de adqusición
    Function CostoTotalAsquisicion()
        Dim CTu As Single
        CTu = U * D
        CTu = Round(CTu, 2)
        Return CTu
    End Function

    'Costo total de la politica
    Function CostoPolitica()
        Dim CTA As Single
        CTA = CostoTotalPreparar() + CostoTotalMantener() + CostoTotalFaltante() + CostoTotalAsquisicion()
        CTA = Round(CTA, 2)
        Return CTA
    End Function
End Class
