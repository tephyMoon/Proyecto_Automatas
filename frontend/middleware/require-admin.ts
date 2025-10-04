export default defineNuxtRouteMiddleware((to) => {
  const isLogged = useState<boolean>('isLogged', () => false)
  const role = useState<string>('role', () => 'analista')
  if (!isLogged.value || role.value !== 'admin') {
    return navigateTo('/login')
  }
})
