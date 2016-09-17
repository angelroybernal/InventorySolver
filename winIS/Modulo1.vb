Imports System.Math

Public Class EOQ1
    Dim D, P, H, U, T, dd, tl As Single
    'D - Demanda anual
    'P - Costo de producción
    'H - Costo de mantener inventario
    'U - Costo por unidad
    'T - Días al año
    'dd - Demanda diaria
    'tl - Tiempo de espera

    'Constructor, asigna los datos de entrada a las variables correspondientes
    Sub New(ByVal val As Array)
        D = val(0)
        P = val(1)
        H = val(2)
        U = val(3)
        T = val(4)
        dd = val(5)
        tl = val(6)
    End Sub

    'Tamaño de pedido optimo
    Function TamañoPedido()
        Dim Q As Single
        Q = ((2 * P * D) / H) ^ (1 / 2)
        Q = Round(Q, 2)
        Return Q
    End Function


    'Tamaño del inventario máximo
    Function InventarioMaximo()
        Dim Imax As Single
        Imax = TamañoPedido()
        Imax = Round(Imax, 2)
        Return Imax
    End Function

    'Cantidad de pedidos necesarios
    Function Npedidos()
        Dim N As Single
        N = D / TamañoPedido()
        N = Round(N, 2)
        Return N
    End Function

    'Duración del ciclo
    Function TiempoCiclo()
        Dim Tc As Single
        Tc = (TamañoPedido() / D) * T
        Tc = Round(Tc, 2)
        Return Tc
    End Function

    'Tiempo de disponibilidad
    Function TiempoDisponibilidad()
        Dim Td As Single
        Td = InventarioMaximo() / dd
        Td = Round(Td, 2)
        Return Td
    End Function

    'Punto de reorden
    Function PuntoReorden()
        Dim L As Single
        L = dd * tl
        L = Round(L, 2)
        Return L
    End Function

    'Costo total de pedidos
    Function CostoTotalPedido()
        Dim CTp As Single
        CTp = (P * D) / TamañoPedido()
        CTp = Round(CTp, 2)
        Return CTp
    End Function

    'Costo total de mantener en inventario
    Function CostoTotalMantener()
        Dim CTh As Single
        CTh = (H * (TamañoPedido()) ^ 2) / (2 * TamañoPedido())
        CTh = Round(CTh, 2)
        Return CTh
    End Function

    'Costo total de adquisición
    Function CostoTotalAsquisicion()
        Dim CTu As Single
        CTu = U * D
        CTu = Round(CTu, 2)
        Return CTu
    End Function

    'Costo total de la politica
    Function CostoPolitica()
        Dim CTA As Single
        CTA = CostoTotalPedido() + CostoTotalMantener() + CostoTotalAsquisicion()
        CTA = Round(CTA, 2)
        Return CTA
    End Function
End Class