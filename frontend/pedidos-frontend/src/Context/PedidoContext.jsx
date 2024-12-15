import { createContext,useState,useContext } from "react";

const PedidoContext = createContext(null)

export const PedidosProvider = ({children}) =>{
    const [vendedor,setVendedor] = useState(null)
    const [items,setItems] = useState([])
    return <PedidoContext.Provider value={{vendedor,setVendedor,items,setItems}}>{children}</PedidoContext.Provider>
} 

export const usePedidos = () => useContext(PedidoContext)