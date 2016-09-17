Imports System.Math

Public Class EOQ2
    Dim D, P, H, B, U, T, dd, tl As Single
    'D - Demanda anual
    'P - Costo de producción
    'H - Costo de mantener inventario
    'B - Costo del faltante
    'U - Costo por unidad
    'T - Días al año
    'dd - Demanda diaria
    'tl - Tiempo de espera

    'Constructor, asigna los datos de entrada a las variables correspondientes
    Sub New(ByVal val As Array)
        D = val(0)
        P = val(1)
        H = val(2)
        B = val(3)
        U = val(4)
        T = val(5)
        dd = val(6)
        tl = val(7)
    End Sub

    'Tamaño de pedido optimo
    Function TamañoPedido()
        Dim Q As Single
        Q = ((2 * P * D * (B + H)) / (B * H)) ^ (1 / 2)
        Q = Round(Q, 2)
        Return Q
    End Function

    'Acumulación de faltantes
    Function PedidosPendientes()
        Dim S As Single
        S = ((2 * P * D * H) / ((B + H) * B)) ^ (1 / 2)
        S = Round(S, 2)
        Return S
    End Function

    'Tamaño del inventario máximo
    Function InventarioMaximo()
        Dim Imax As Single
        Imax = ((2 * P * D * B) / ((B + H) * H)) ^ (1 / 2)
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

    'Tiempo de faltante
    Function TiempoFaltante()
        Dim Tf As Single
        Tf = PedidosPendientes() / dd
        Tf = Round(Tf, 2)
        Return Tf
    End Function

    'Punto de reorden
    Function PuntoReorden()
        Dim L As Single
        L = -PedidosPendientes() + (dd * tl)
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
        CTh = (H * (TamañoPedido() - PedidosPendientes()) ^ 2) / (2 * TamañoPedido())
        CTh = Round(CTh, 2)
        Return CTh
    End Function

    'Costo total de faltantes
    Function CostoTotalFaltante()
        Dim CTb As Single
        CTb = (B * PedidosPendientes() ^ 2) / (2 * TamañoPedido())
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
        CTA = CostoTotalPedido() + CostoTotalMantener() + CostoTotalFaltante() + CostoTotalAsquisicion()
        CTA = Round(CTA, 2)
        Return CTA
    End Function
End Class