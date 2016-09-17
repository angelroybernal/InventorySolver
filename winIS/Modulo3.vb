Imports System.Math

Public Class EPQ1
    Dim D, P, H, K, T, dd, tl, U As Single
    'D - Demanda anual
    'P - Costo de preparar una tanda
    'H - Costo de mantener inventario
    'K - Producción diaria
    'T - Días al año
    'dd - Demanda diaria
    'tl - Tiempo de preparar la planta
    'U - Costo por unidad

    'Constructor, asigna los datos de entrada a las variables correspondientes
    Sub New(ByVal val As Array)
        D = val(0)
        P = val(1)
        H = val(2)
        K = val(3)
        T = val(4)
        dd = val(5)
        tl = val(6)
        U = val(7)
    End Sub

    'Tamaño del lote optimo a producir
    Function TamañoLote()
        Dim Q As Single
        Q = ((2 * P * D) / (H * (1 - (dd / K)))) ^ (1 / 2)
        Q = Round(Q, 2)
        Return Q
    End Function

    'Tamaño del inventario máximo
    Function InventarioMaximo()
        Dim Imax As Single
        Imax = TamañoLote() * (1 - (dd / K))
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

    'Punto de reorden
    Function PuntoReorden()
        Dim L As Single
        L = dd * tl
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
        CTh = (H * TamañoLote() * (1 - dd / K)) / 2
        CTh = Round(CTh, 2)
        Return CTh
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
        CTA = CostoTotalPreparar() + CostoTotalMantener() + CostoTotalAsquisicion()
        CTA = Round(CTA, 2)
        Return CTA
    End Function
End Class