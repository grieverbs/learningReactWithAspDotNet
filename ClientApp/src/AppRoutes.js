import { Home } from "./components/Home";
import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { HelloWorld } from "./components/HelloWorld";
import { Emoji } from "./components/Emoji";

const AppRoutes = [
    {
        index: true,
        element: <Home />
    },
    {
        path: '/counter',
        element: <Counter />
    },
    {
        path: '/fetch-data',
        element: <FetchData />
    },
    {
        path: '/hello-world',
        element: <HelloWorld />
    },
    {
        path: '/emoji',
        element: <Emoji />
    }
];

export default AppRoutes;
