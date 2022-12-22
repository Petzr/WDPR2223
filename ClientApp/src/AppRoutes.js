import { Home } from "./Pages/Home";
import { OverOns } from "./Pages/OverOns";
import { VoorstellingPage } from "./Pages/VoorstellingPage";
import { LoginPage } from "./Pages/Login/LoginPage";
import { CreateAccountPage } from "./Pages/Login/CreateAccountPage";
import { StoelKiezenPage } from "./Pages/StoelenKiezen/StoelKiezenPage";
import { VoorstellingAdding } from "./Pages/VoegToe/VoegVoorstellingToePage";
import {VoegArtiestToeAanLijst  } from "./Pages/VoegToe/VoegArtiestToePage";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/voorstelling',
    element: <VoorstellingPage />
  },
  {
    path: '/overons',
    element: <OverOns />
  },
  {
    path: 'Login',
    element: <LoginPage />
  },
  {
    path: '/CreateAccount',
    element: <CreateAccountPage />
  },
  {
    path: '/StoelKiezen',
    element: <StoelKiezenPage />
  },  
  {
    path: '/AddVoorstelling',
    element: <VoorstellingAdding />
  }, 
  {
    path: '/AddArtiest',
    element: <VoegArtiestToeAanLijst />
  },
  ];

export default AppRoutes;
