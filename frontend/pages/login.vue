<script setup lang="ts">
definePageMeta({ layout: 'public' })

/**
 * Formulario maquetado (sin conexión a backend).
 * 🔌 Integración futura:
 *  - Reemplazar handleLogin con llamada a POST /auth/login y gestionar JWT.
 */
const form = reactive({ username: '', password: '' })
const loading = ref(false)
const msg = ref<string | null>(null)

const handleLogin = async () => {
  loading.value = true
  msg.value = null
  // Simulación de éxito (solo frontend):
  await new Promise(r => setTimeout(r, 700))
  // Guardamos estado simulado
  const isLogged = useState<boolean>('isLogged')
  const role = useState<string>('role')
  isLogged.value = true
  role.value = 'analista'
  loading.value = false
  navigateTo('/dashboard')
}
</script>

<template>
  <div class="w-full max-w-md space-y-4">
    <h2 class="text-2xl font-semibold">Iniciar sesión</h2>
    <form @submit.prevent="handleLogin" class="space-y-3">
      <input v-model="form.username" placeholder="Usuario o correo" class="w-full px-3 py-2 rounded-lg bg-primary/50 border border-primary" required />
      <input v-model="form.password" type="password" placeholder="Contraseña" class="w-full px-3 py-2 rounded-lg bg-primary/50 border border-primary" required />
      <button :disabled="loading" class="w-full px-4 py-2 rounded-lg bg-accent/80 hover:bg-accent/90">
        {{ loading ? 'Ingresando...' : 'Ingresar' }}
      </button>
    </form>
    <div class="text-sm opacity-80">¿Olvidaste tu contraseña? <a href="#" class="text-accent">Recuperar</a></div>
    <p v-if="msg" class="text-sm text-accent">{{ msg }}</p>
  </div>
</template>
