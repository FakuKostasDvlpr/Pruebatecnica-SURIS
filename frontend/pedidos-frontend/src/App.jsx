
import Articulos from './Components/Articulos';
import Vendedores from './Components/Vendedores';
import CrearPedido from './Components/CrearPedido';
import ListaPedidos from './Components/ListaPedidos';
import { PedidosProvider } from './Context/PedidoContext';

function App() {
    
    return (
        <> 
            <PedidosProvider>

            <Articulos/>
            <Vendedores/>
            <CrearPedido/>

            </PedidosProvider>
            <ListaPedidos/>
        </>
    );
}

export default App;
