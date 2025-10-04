export default defineNuxtRouteMiddleware((to) => {
  // Simulación de sesión con useState (frontend only).
  const isLogged = useState<boolean>('isLogged', () => false)
  if (!isLogged.value) {
    return navigateTo('/login')
  }
})
